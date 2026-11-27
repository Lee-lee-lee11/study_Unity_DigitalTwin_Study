using UnityEngine;

public class MachineState81 : MonoBehaviour
{
    public enum State{Idle,Running,Fault} public State Current{get;private set;}
    [ContextMenu("Run")] public void Run(){if(Current==State.Idle)Current=State.Running;}
    [ContextMenu("Stop")] public void Stop(){if(Current==State.Running)Current=State.Idle;}
    [ContextMenu("Trip")] public void Trip()=>Current=State.Fault;
    public bool causeCleared;
    [ContextMenu("Reset")] public void ResetFault(){if(Current==State.Fault&&causeCleared)Current=State.Idle;}
}
