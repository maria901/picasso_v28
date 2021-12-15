#include <windows.h>

void dprintf(char *format, ...);

int __stdcall interface1()
{

#ifdef NPRINTF
    dprintf("Printing message box to debug other people code as usual\n");
#endif

    return MessageBox(0, "Thanks for using our software", "Hi", MB_ABORTRETRYIGNORE | MB_TOPMOST);
}

int __stdcall About()
{
    return interface1();
}