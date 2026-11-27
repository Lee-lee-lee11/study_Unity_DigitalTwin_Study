using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Interop;
public sealed class NativeViewport : HwndHost {
 public IntPtr HostHandle {get;private set;}
 [DllImport("user32.dll",CharSet=CharSet.Unicode,SetLastError=true)]
 static extern IntPtr CreateWindowEx(int exStyle,string cls,string name,int style,int x,int y,int w,int h,IntPtr parent,IntPtr menu,IntPtr instance,IntPtr param);
 [DllImport("user32.dll",SetLastError=true)] static extern bool DestroyWindow(IntPtr hwnd);
 protected override HandleRef BuildWindowCore(HandleRef hwndParent){
  HostHandle=CreateWindowEx(0,"STATIC","Unity host",0x50000000,0,0,1,1,hwndParent.Handle,IntPtr.Zero,IntPtr.Zero,IntPtr.Zero);
  if(HostHandle==IntPtr.Zero)throw new Win32Exception(Marshal.GetLastWin32Error());return new HandleRef(this,HostHandle);
 }
 protected override void DestroyWindowCore(HandleRef hwnd){DestroyWindow(hwnd.Handle);HostHandle=IntPtr.Zero;}
}
// MainWindow constructor: Viewport.Child = new NativeViewport(); (88강 Border)
// 시작은 HostHandle != IntPtr.Zero 확인 후. Player를 먼저 종료한 뒤 Host를 해제한다.
