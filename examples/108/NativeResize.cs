using System;
using System.Runtime.InteropServices;
public static class NativeResize {
 [StructLayout(LayoutKind.Sequential)] struct RECT{public int Left,Top,Right,Bottom;}
 [DllImport("user32.dll")] static extern bool GetClientRect(IntPtr hwnd,out RECT rect);
 [DllImport("user32.dll",SetLastError=true)] static extern bool MoveWindow(IntPtr hwnd,int x,int y,int w,int h,bool repaint);
 public static bool Resize(IntPtr host,IntPtr child){
  if(host==IntPtr.Zero||child==IntPtr.Zero||!GetClientRect(host,out var r))return false;
  int w=r.Right-r.Left,h=r.Bottom-r.Top;return w>0&&h>0&&MoveWindow(child,0,0,w,h,true);
 }
}
// Call only after verifying the Unity child HWND/PID and readiness per Unity docs.
