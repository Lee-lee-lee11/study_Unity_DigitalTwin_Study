using UnityEngine;
using System.IO;
using System.IO.Pipes;
using System.Text;
using System.Collections.Concurrent;
public class PipeClientDemo : MonoBehaviour
{
    readonly ConcurrentQueue<string> logs=new ConcurrentQueue<string>();
    NamedPipeClientStream pipe;
    async void Start(){try{pipe=new NamedPipeClientStream(".","machine-sim-demo",PipeDirection.InOut,PipeOptions.Asynchronous);
     await pipe.ConnectAsync(3000);using(var writer=new StreamWriter(pipe,new UTF8Encoding(false),1024,true)){writer.AutoFlush=true;await writer.WriteLineAsync("ping");}
     using(var reader=new StreamReader(pipe,new UTF8Encoding(false),false,1024,true)){logs.Enqueue(await reader.ReadLineAsync() ?? "Disconnected");}}
     catch(System.Exception e){logs.Enqueue(e.Message);}finally{pipe?.Dispose();}}
    void Update(){while(logs.TryDequeue(out var message))Debug.Log(message);}
    void OnDestroy(){pipe?.Dispose();}
}
