using System.IO;
using Microsoft.Win32;
public static class FileDialog {
 public static string? SelectGlb(){var dialog=new OpenFileDialog{Filter="GLB model (*.glb)|*.glb",CheckFileExists=true,Multiselect=false};
 if(dialog.ShowDialog()!=true)return null;
 var f=new FileInfo(dialog.FileName);if(f.Length>100*1024*1024)throw new IOException("File too large");return f.FullName;}
}
