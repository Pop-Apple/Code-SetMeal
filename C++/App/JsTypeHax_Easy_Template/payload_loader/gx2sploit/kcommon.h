#ifndef _K_COMMON_H_
#define _K_COMMON_H_

#ifdef __cplusplus
extern "C" {
#endif

#include <stdint.h>

#define OSDynLoad_Acquire ((void (*)(char* rpl, unsigned int *handle))0x0102A3B4)
#define OSDynLoad_FindExport ((void (*)(unsigned int handle, int isdata, char *symbol, void *address))0x0102B828)
#define OSFatal ((void (*)(char* msg))0x01031618)
#define __os_snprintf ((int(*)(char* s, int n, const char * format, ... ))0x0102F160)

#define BUS_SPEED                       248625000
#define SECS_TO_TICKS(sec) (((unsigned long long)(sec)) * (BUS_SPEED/4))

typedef struct OSContext_ {
    char tag[8];

    uint32_t gpr[32];

    uint32_t cr;
    uint32_t lr;
    uint32_t ctr;
    uint32_t xer;

    uint32_t srr0;
    uint32_t srr1;

    uint32_t ex0;
    uint32_t ex1;

    uint32_t exception_type;
    uint32_t reserved;

    double fpscr;
    double fpr[32];

    uint16_t spinLockCount;
    uint16_t state;

    uint32_t gqr[8];
    uint32_t pir;
    double psf[32];

    uint64_t coretime[3];
    uint64_t starttime;

    uint32_t error;
    uint32_t attributes;

    uint32_t pmc1;
    uint32_t pmc2;
    uint32_t pmc3;
    uint32_t pmc4;
    uint32_t mmcr0;
    uint32_t mmcr1;
} OSContext;

#ifdef __cplusplus
}
#endif

#endif
