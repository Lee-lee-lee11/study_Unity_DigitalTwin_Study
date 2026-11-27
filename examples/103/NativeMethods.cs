using System;
using System.Runtime.InteropServices;
public static class NativeMethods {
 [DllImport("user32.dll", SetLastError=true)] public static extern uint GetWindowThreadProcessId(IntPtr hWnd,out uint pid);
}
