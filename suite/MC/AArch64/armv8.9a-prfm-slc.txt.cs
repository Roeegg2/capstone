# CS_ARCH_AARCH64, 0, None

0x66,0x00,0x80,0xf9 == prfm pldslckeep, [x3]
0x67,0x00,0x80,0xf9 == prfm pldslcstrm, [x3]
0x6e,0x00,0x80,0xf9 == prfm plislckeep, [x3]
0x6f,0x00,0x80,0xf9 == prfm plislcstrm, [x3]
0x76,0x00,0x80,0xf9 == prfm pstslckeep, [x3]
0x77,0x00,0x80,0xf9 == prfm pstslcstrm, [x3]
0x06,0x00,0x00,0xd8 == prfm pldslckeep, #0
0x66,0x68,0xa5,0xf8 == prfm pldslckeep, [x3, x5]
