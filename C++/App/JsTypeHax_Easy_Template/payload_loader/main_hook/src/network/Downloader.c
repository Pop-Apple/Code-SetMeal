#include "Downloader.h"
#include "../common.h"
#include <dynamic_libs/curl_functions.h>

void *xmemcpy(void *addr, void *val, unsigned int size) {
    char *addrp      = (char*)addr;
    const char *valp = (const char*)val;
    while (size--) {
        *addrp++ = *valp++;
    }
    return addr;
}

// #define EXPORT_DECL(res, func, ...)     res (* func)(__VA_ARGS__) __attribute__((section(".data"))) = 0;

void *xrealloc(void *ptr, size_t size, os_function_ptr_t os_functions) {
    void *newPtr;

    if (!ptr) {
        newPtr = os_functions.MEMAllocFromDefaultHeap(size);
        if (!newPtr) {
            goto error;
        }
    } else {
        newPtr = os_functions.MEMAllocFromDefaultHeap(size);
        if (!newPtr) {
            goto error;
        }

        xmemcpy(newPtr, ptr, size);

        os_functions.MEMFreeToDefaultHeap(ptr);
    }

    return newPtr;
error:
    return NULL;
}

int curlCallback(void *buffer, int size, int nmemb, void *userp) {
    curl_private_data_t *private_data = (curl_private_data_t *)userp;
    int read_len = size * nmemb;

    if(0) {
        // int res = private_data->file->write((unsigned char*)buffer, read_len);
        // private_data->filesize += res;
        // return res;
    } else {
        if(!private_data->buffer) {
            private_data->buffer = (unsigned char*) private_data->os_functions.MEMAllocFromDefaultHeap(read_len);
        } else {
            unsigned char *tmp = (unsigned char*) xrealloc(private_data->buffer, private_data->filesize + read_len, private_data->os_functions);
            if(!tmp) {
                private_data->os_functions.MEMFreeToDefaultHeap(private_data->buffer);
                private_data->buffer = NULL;
            } else {
                private_data->buffer = tmp;
            }
        }

        if(!private_data->buffer) {
            private_data->filesize = 0;
            return -1;
        }

        xmemcpy(private_data->buffer + private_data->filesize, buffer, read_len);
        private_data->filesize += read_len;
        return read_len;
    }
}

int internalGetFile(const char *url, curl_private_data_t *private_data) {
    int result = 0;
    int resp = 404;
    int ret = -1;
    private_data->nsysnet_functions.socket_lib_init();
    private_data->curl_functions.curl_ptr = private_data->curl_functions.n_curl_easy_init();
    if(!private_data->curl_functions.curl_ptr) {
        return 0;
    }

    /*
    std::string prefix = "https";
    if(strncmp(downloadUrl.c_str(), prefix.c_str(), prefix.size()) == 0) {
        ssl_context = NSSLCreateContext(0);
        if(ssl_context < 0) {
            goto exit_error;
        }

        // Add all existing certs
        for(int i = 100; i<106; i++) {
            NSSLAddServerPKI(ssl_context,i);
        }

        for(int i = 1001; i<1034; i++) {
            NSSLAddServerPKI(ssl_context,i);
        }
        n_curl_easy_setopt(curl, CURLOPT_GSSAPI_DELEGATION, ssl_context); // Is CURLOPT_NSSL_CONTEXT on the Wii U
    }
    */

    private_data->curl_functions.n_curl_easy_setopt(private_data->curl_functions.curl_ptr, CURLOPT_URL, url);
    private_data->curl_functions.n_curl_easy_setopt(private_data->curl_functions.curl_ptr, CURLOPT_WRITEFUNCTION, curlCallback);
    private_data->curl_functions.n_curl_easy_setopt(private_data->curl_functions.curl_ptr, CURLOPT_WRITEDATA, private_data);
    private_data->curl_functions.n_curl_easy_setopt(private_data->curl_functions.curl_ptr, CURLOPT_FOLLOWLOCATION, 1L);

    // n_curl_easy_setopt(curl, CURLOPT_ERRORBUFFER, errbuf);

    /*
    if(private_data->progressCallback) {
        n_curl_easy_setopt(curl, CURLOPT_PROGRESSFUNCTION, FileDownloader::curlProgressCallback);
        n_curl_easy_setopt(curl, CURLOPT_PROGRESSDATA, private_data);
        n_curl_easy_setopt(curl, CURLOPT_NOPROGRESS, 0L);
    }
    */

    ret = private_data->curl_functions.n_curl_easy_perform(private_data->curl_functions.curl_ptr);
    if(ret) {
        OSFatal("ret");
    }

    if(!private_data->filesize) {
        OSFatal("filesize");
    }

    private_data->curl_functions.n_curl_easy_getinfo(private_data->curl_functions.curl_ptr, CURLINFO_RESPONSE_CODE, &resp);

    if(resp != 200) {
        OSFatal("resp");
    }

    result = 1;

exit_error:
    /*
    if(ssl_context >= 0) {
        NSSLDestroyContext(ssl_context);
    }
    */

    private_data->curl_functions.n_curl_easy_cleanup(private_data->curl_functions.curl_ptr);
    return result;
}

int getFile(const char *url, char **outBuffer, curl_function_ptr_t curl_functions, os_function_ptr_t os_functions, nsysnet_function_ptr_t nsysnet_functions) {
    curl_private_data_t private_data;
    // private_data.progressCallback = callback;
    private_data.progressArg = 0;
    private_data.buffer = 0;
    private_data.filesize = 0;

    private_data.curl_functions    = curl_functions;
    private_data.os_functions      = os_functions;
    private_data.nsysnet_functions = nsysnet_functions;

    int result = internalGetFile(url, &private_data);

    if(private_data.filesize > 0 && private_data.buffer) {
        char *buffer = os_functions.MEMAllocFromDefaultHeap(private_data.filesize);
        xmemcpy(buffer, private_data.buffer, private_data.filesize);
        *outBuffer = buffer;
    }

    if(private_data.buffer) {
        os_functions.MEMFreeToDefaultHeap(private_data.buffer);
    }

    return result;
}

void init_os_function_ptr(os_function_ptr_t *ptr) {
    unsigned int coreinit_handle;
    OSDynLoad_Acquire("coreinit.rpl", &coreinit_handle);

    unsigned int *function_pointer;

    OSDynLoad_FindExport(coreinit_handle, 1, "MEMAllocFromDefaultHeapEx", &function_pointer);
    ptr->MEMAllocFromDefaultHeapEx = (void*(*)(unsigned int, unsigned int))*function_pointer;
    OSDynLoad_FindExport(coreinit_handle, 1, "MEMAllocFromDefaultHeap", &function_pointer);
    ptr->MEMAllocFromDefaultHeap = (void*(*)(unsigned int))*function_pointer;
    OSDynLoad_FindExport(coreinit_handle, 1, "MEMFreeToDefaultHeap", &function_pointer);
    ptr->MEMFreeToDefaultHeap = (void (*)(void *))*function_pointer;

    OSDynLoad_FindExport(coreinit_handle, 0, "memset", &ptr->p_memset);
    OSDynLoad_FindExport(coreinit_handle, 0, "memcpy", &ptr->p_memcpy);
    OSDynLoad_FindExport(coreinit_handle, 0, "DCFlushRange", &ptr->DCFlushRange);
    OSDynLoad_FindExport(coreinit_handle, 0, "ICInvalidateRange", &ptr->ICInvalidateRange);
    OSDynLoad_FindExport(coreinit_handle, 0, "OSCreateThread", &ptr->OSCreateThread);
    OSDynLoad_FindExport(coreinit_handle, 0, "OSResumeThread", &ptr->OSResumeThread);
    OSDynLoad_FindExport(coreinit_handle, 0, "OSIsThreadTerminated", &ptr->OSIsThreadTerminated);
    OSDynLoad_FindExport(coreinit_handle, 0, "OSExitThread", &ptr->OSExitThread);
    OSDynLoad_FindExport(coreinit_handle, 0, "OSJoinThread", &ptr->OSJoinThread);
    OSDynLoad_FindExport(coreinit_handle, 0, "OSYieldThread", &ptr->OSYieldThread);
}

void init_curl_function_ptr(curl_function_ptr_t *ptr) {
    unsigned int nlibcurl_handle;
    OSDynLoad_Acquire("nlibcurl.rpl", &nlibcurl_handle);

    OSDynLoad_FindExport(nlibcurl_handle, 0, "curl_global_init", &ptr->n_curl_global_init);
    OSDynLoad_FindExport(nlibcurl_handle, 0, "curl_easy_init", &ptr->n_curl_easy_init);
    OSDynLoad_FindExport(nlibcurl_handle, 0, "curl_easy_setopt", &ptr->n_curl_easy_setopt);
    OSDynLoad_FindExport(nlibcurl_handle, 0, "curl_easy_perform", &ptr->n_curl_easy_perform);
    OSDynLoad_FindExport(nlibcurl_handle, 0, "curl_easy_getinfo", &ptr->n_curl_easy_getinfo);
    OSDynLoad_FindExport(nlibcurl_handle, 0, "curl_easy_cleanup", &ptr->n_curl_easy_cleanup);
    ptr->curl_ptr = NULL;
}

void init_nsysnet_function_ptr(nsysnet_function_ptr_t *ptr) {
    unsigned int nsysnet_handle;
    OSDynLoad_Acquire("nsysnet.rpl", &nsysnet_handle);

    OSDynLoad_FindExport(nsysnet_handle, 0, "socket_lib_init", &ptr->socket_lib_init);
}