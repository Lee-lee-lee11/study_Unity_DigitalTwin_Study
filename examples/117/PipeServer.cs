using System.IO;
using System.IO.Pipes;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
public static class PipeServer {
 public static async Task RunOnceAsync(CancellationToken token){
  using var pipe=new NamedPipeServerStream("machine-sim-demo",PipeDirection.InOut,1,PipeTransmissionMode.Byte,PipeOptions.Asynchronous|PipeOptions.CurrentUserOnly);
  await pipe.WaitForConnectionAsync(token);
  using var reader=new StreamReader(pipe,new UTF8Encoding(false),false,1024,true);
  using var writer=new StreamWriter(pipe,new UTF8Encoding(false),1024,true){AutoFlush=true};
  // Single trusted local ping/pong exercise. Production: bounded framing before decoding.
  var line=await reader.ReadLineAsync(token);
  if(line=="ping")await writer.WriteLineAsync("pong");
 }
}
// Call from an async WPF event handler; catch IOException/OperationCanceledException; cancel on closing.
