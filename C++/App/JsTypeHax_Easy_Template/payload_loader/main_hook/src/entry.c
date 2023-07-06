#include "network/Downloader.h"
#include "elf_abi.h"
#include "fs_defs.h"
#include "common.h"
#include "utils.h"
#include "structs.h"
#include "elf_loading.h"
#include "memory_setup.h"

int _start(int argc, char **argv) {
    curl_function_ptr_t    curl_functions;
    os_function_ptr_t      os_functions;
    nsysnet_function_ptr_t nsysnet_functions;

    init_curl_function_ptr(&curl_functions);
    init_os_function_ptr(&os_functions);
    init_nsysnet_function_ptr(&nsysnet_functions);

    const unsigned char *elf_file = setup_memory(curl_functions, os_functions, nsysnet_functions);

    uint32_t newEntry = LoadFromMem(elf_file, &os_functions);

    return ((int (*)(int, char **))newEntry)(argc, argv);
}