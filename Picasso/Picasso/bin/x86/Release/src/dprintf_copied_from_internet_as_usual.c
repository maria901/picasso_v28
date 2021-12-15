#include <stdio.h>
#include <windows.h>



void
dprintf (char *format, ...)
{
#ifndef NPRINTF
return;
#else
  {
    va_list args;
    static char buffer[1000000];
    int ret;
    va_start (args, format);
    ret = vsprintf (buffer, format, args);

    OutputDebugString (buffer);
	
  }
#endif
  return;
}

