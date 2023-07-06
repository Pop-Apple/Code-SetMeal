#ifndef __DOWNLOADER_H__
#define __DOWNLOADER_H__

#include <dynamic_libs/curl_functions.h>
#include <curl/curl.h>

typedef struct {
    void* (*p_memset)(void * dest, unsigned int value, unsigned int bytes);
    void* (*p_memcpy)(void * dest, void * val, unsigned int size);
    void  (*DCFlushRange)(const void *dest, unsigned int size);
    void  (*ICInvalidateRange)(const void *dest, unsigned size);
    void* (*MEMAllocFromDefaultHeapEx)(unsigned int size, unsigned int align);
    void* (*MEMAllocFromDefaultHeap)(unsigned int size);
    void  (*MEMFreeToDefaultHeap)(void *ptr);
    void (*OSExitThread)(int);
    void (*OSYieldThread)(void);
    int  (*OSCreateThread)(void *thread, void *entry, int argc, void *args, unsigned int stack, unsigned int stack_size, int priority, unsigned short attr);
    int  (*OSResumeThread)(void *thread);
    int  (*OSIsThreadTerminated)(void *thread);
    int  (*OSJoinThread)(void *thread,int * returnVal);
} os_function_ptr_t;

typedef struct {
    CURLcode (*n_curl_global_init)(long flags);
    CURL* (*n_curl_easy_init)();
    CURLcode (*n_curl_easy_setopt)(void *cptr, CURLoption, ...);
    CURLcode (*n_curl_easy_perform)(void *cptr);
    void (*n_curl_easy_cleanup)(void *cptr);
    CURLcode (*n_curl_easy_getinfo)(void *cptr, CURLINFO, ...);
    CURL *curl_ptr;
} curl_function_ptr_t;

typedef struct {
    void (*socket_lib_init)();
} nsysnet_function_ptr_t;

typedef struct {
    void *progressArg;
    unsigned char *buffer;
    unsigned int filesize;
    curl_function_ptr_t curl_functions;
    os_function_ptr_t os_functions;
    nsysnet_function_ptr_t nsysnet_functions;
} curl_private_data_t;

void init_os_function_ptr(os_function_ptr_t *ptr);
void init_curl_function_ptr(curl_function_ptr_t *ptr);
void init_nsysnet_function_ptr(nsysnet_function_ptr_t *ptr);

int curlCallback(void *buffer, int size, int nmemb, void *userp);
int internalGetFile(const char *url, curl_private_data_t *private_data);
int getFile(const char *url, char **outBuffer, curl_function_ptr_t curl_functions, os_function_ptr_t os_functions, nsysnet_function_ptr_t nsysnet_functions);

/*
int internalGetFile(const char *dlUrl, curl_private_data_t *private_data);
int getFile(const char *dlUrl, char **outBuffer);
*/

#endif