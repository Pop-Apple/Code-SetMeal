#ifndef ELF_LOADIUNG_H
#define	COMMON_H

#include <stdint.h>
#include "network/Downloader.h"

#ifdef __cplusplus
extern "C" {
#endif

uint32_t LoadFromMem(const unsigned char *pElfBuffer, os_function_ptr_t *os_functions);

#ifdef __cplusplus
}
#endif

#endif	/* ELF_LOADIUNG_H */
