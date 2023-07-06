OUTPUT(payload_loader.elf);

ENTRY(_start);

SECTIONS {    
	. = 0x011DD000;
	.text : {		
		*(.text*);
	}
	.data : {
		*(.rodata*);		
		*(.bss*);
		*(.sbss*);
	}
	/DISCARD/ : {
		*(*);
	}
}

ASSERT((SIZEOF(.text) + SIZEOF(.data)) < 0x1D00, "please recude the size.");