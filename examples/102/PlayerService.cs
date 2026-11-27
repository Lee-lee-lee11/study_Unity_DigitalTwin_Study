using System;
using System.Diagnostics;
using System.IO;
public sealed class PlayerService {
 public Process? Player {get;private set;}
 public Process Start(string exe, IntPtr host=default){
  if(Player is {HasExited:false})throw new InvalidOperationException("Already running");
  exe=Path.GetFullPath(exe); if(!File.Exists(exe))throw new FileNotFoundException(exe);
  var psi=new ProcessStartInfo(exe){UseShellExecute=false,WorkingDirectory=Path.GetDirectoryName(exe)!};
  if(host!=IntPtr.Zero){psi.ArgumentList.Add("-parentHWND");psi.ArgumentList.Add(host.ToInt64().ToString(System.Globalization.CultureInfo.InvariantCulture));}
  Player?.Dispose(); Player=Process.Start(psi)??throw new InvalidOperationException("Start failed");Player.EnableRaisingEvents=true;return Player;
 }
 // 종료 정책 및 Exited 이벤트는 114강에서 추가. 호스트 핸들 생성 후 시작한다.
}
