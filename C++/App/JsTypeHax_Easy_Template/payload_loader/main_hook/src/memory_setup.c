#include "memory_setup.h"
#include "utils.h"
#include "network/Downloader.h"
#include <dynamic_libs/curl_functions.h>
#include <curl/curl.h>

/* assembly functions */
extern void SC_0x09_SETIBAT0(uint32_t upper, uint32_t lower);
extern void SC_0x36_SETBATS(void);

void *tmemcpy(void *addr, void *val, unsigned int size) {
    char *addrp      = (char*)addr;
    const char *valp = (const char*)val;
    while (size--) {
        *addrp++ = *valp++;
    }
    return addr;
}

static void SCSetupIBAT4DBAT5() {
    asm volatile("eieio; isync");

    // Give our and the kernel full execution rights.
    // 00800000-01000000 => 30800000-31000000 (read/write, user/supervisor)
    unsigned int ibat4u = 0x008000FF;
    unsigned int ibat4l = 0x30800012;
    asm volatile("mtspr 560, %0" : : "r" (ibat4u));
    asm volatile("mtspr 561, %0" : : "r" (ibat4l));

    // Give our and the kernel full data access rights.
    // 00800000-01000000 => 30800000-31000000 (read/write, user/supervisor)
    unsigned int dbat5u = ibat4u;
    unsigned int dbat5l = ibat4l;
    asm volatile("mtspr 570, %0" : : "r" (dbat5u));
    asm volatile("mtspr 571, %0" : : "r" (dbat5l));

    asm volatile("eieio; isync");
}

static void thread_callback(int argc, void *argv) {
    // We need to give the kernel access to our memory.
    // VA: 01000000..01800000 PA: 32000000..32800000  with r/w for user and supervisor
    SC_0x09_SETIBAT0(0x010000FF,0x32000012);

    // Setting the IBAT and DBAT to give us full access (rwx) to 0x00800000 - 0x010000000
    SC_0x36_SETBATS();
}

const unsigned char *setup_memory(curl_function_ptr_t curl_functions, os_function_ptr_t os_functions, nsysnet_function_ptr_t nsysnet_functions) {
    /*
    The syscall is already (expected to be) set up by the loader at this point.

    uint32_t setIBAT0 = 0xFFF02344;
    kern_write((void*)(KERN_SYSCALL_TBL_1 + (0x25 * 4)), (uint32_t) setIBAT0);
    kern_write((void*)(KERN_SYSCALL_TBL_2 + (0x25 * 4)), (uint32_t) setIBAT0);
    kern_write((void*)(KERN_SYSCALL_TBL_3 + (0x25 * 4)), (uint32_t) setIBAT0);
    kern_write((void*)(KERN_SYSCALL_TBL_4 + (0x25 * 4)), (uint32_t) setIBAT0);
    kern_write((void*)(KERN_SYSCALL_TBL_5 + (0x25 * 4)), (uint32_t) setIBAT0); */

    // Setup the IBAT DBAT syscall
    kern_write((void*)(KERN_SYSCALL_TBL_1 + (0x36 * 4)), (uint32_t) SCSetupIBAT4DBAT5);
    kern_write((void*)(KERN_SYSCALL_TBL_2 + (0x36 * 4)), (uint32_t) SCSetupIBAT4DBAT5);
    kern_write((void*)(KERN_SYSCALL_TBL_3 + (0x36 * 4)), (uint32_t) SCSetupIBAT4DBAT5);
    kern_write((void*)(KERN_SYSCALL_TBL_4 + (0x36 * 4)), (uint32_t) SCSetupIBAT4DBAT5);
    kern_write((void*)(KERN_SYSCALL_TBL_5 + (0x36 * 4)), (uint32_t) SCSetupIBAT4DBAT5);
    //if (!curl_handle) OSFatal("Curl init failed");

    void *stack = os_functions.MEMAllocFromDefaultHeapEx(0x4000, 0x20);
    //
    // Create the thread variable
    void *thread = os_functions.MEMAllocFromDefaultHeapEx(0x1000, 8);
    if(!thread || !stack) {
        OSFatal("e1");
    }

    // Create one thread for each core
    for(int i = 0; i<3; i++) {
        os_functions.p_memset(stack,0,0x4000);
        os_functions.p_memset(thread,0,0x1000);

        int ret = os_functions.OSCreateThread(thread, thread_callback, 0, (void*)0, (unsigned int)stack+0x4000, 0x4000, 0, 0x8 + (1 << i));
        if (ret == 0) {
            OSFatal("e2");
        }

        // Schedule it for execution
        os_functions.OSResumeThread(thread);

        // wait until terminated
        while(os_functions.OSIsThreadTerminated(thread) == 0) {
            os_functions.OSYieldThread();
        }
    }

    os_functions.MEMFreeToDefaultHeap(stack);
    os_functions.MEMFreeToDefaultHeap(thread);

    const char *url = "Your payload.elf file url";

    char *buffer;

    getFile(url, &buffer, curl_functions, os_functions, nsysnet_functions);

    return (const unsigned char*)buffer;
}
