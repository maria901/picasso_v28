amanda_32:
	i686-w64-mingw32-gcc.exe -O3 -mdll -o rsp_small_little_dll_32.dll rsp_software_original_source_code.c microsoft_corporation.def \
	dprintf_copied_from_internet_as_usual.c -Wl,-enable-stdcall-fixup

	cp "rsp_small_little_dll_32.dll" 'C:/AMANDA AVA KOCI PEREIRA/nosso_trabalho/amanda_projects/project picasso/x86'
ricardo_64:
	x86_64-w64-mingw32-gcc.exe -O3 -mdll -o rsp_small_little_dll_64.dll rsp_software_original_source_code.c microsoft_corporation.def \
	dprintf_copied_from_internet_as_usual.c

	cp "rsp_small_little_dll_64.dll" 'C:\AMANDA AVA KOCI PEREIRA\nosso_trabalho\amanda_projects\project picasso\'
	
amanda:
	gcc -O3 -mdll -o rsp_small_little_dll_32.dll rsp_software_original_source_code.c microsoft_corporation.def \
	dprintf_copied_from_internet_as_usual.c
	
	cp "rsp_small_little_dll_32.dll" "../rsp_small_little_dll_32.dll"
	
chukran:
	cl  /Gy /MT /Ox /LD \
	\
	\
	\
	\
	\
	/DNPRINTF2 \
	/Fersp_small_little_dll_32.dll \
	rsp_software_original_source_code.c microsoft_corporation.def \
	kernel32.lib user32.lib shell32.lib \
	dprintf_copied_from_internet_as_usual.c
	

	copy "rsp_small_little_dll_32.dll" "..\rsp_small_little_dll_32.dll" /Y
	
