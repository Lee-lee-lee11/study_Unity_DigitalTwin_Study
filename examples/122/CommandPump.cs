using UnityEngine;
using System.Collections.Concurrent;
public class CommandPump : MonoBehaviour
{
    readonly ConcurrentQueue<CommandDto> queue=new ConcurrentQueue<CommandDto>();
    public DoorDrive door;
    public void Enqueue(CommandDto command)=>queue.Enqueue(command);
    void Update(){for(int n=0;n<32&&queue.TryDequeue(out var cmd);n++){
     if(door && cmd.command=="SetAngle" && cmd.target=="door-01" && !float.IsNaN(cmd.value)&&!float.IsInfinity(cmd.value)&&cmd.value>=0&&cmd.value<=90)door.SetAngle(cmd.value);
     else Debug.LogWarning("Rejected command");}}
}
