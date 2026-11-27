using UnityEngine;

public class DoorCommands : MonoBehaviour
{
    public float target;
    public bool moving;
    [ContextMenu("Open")] public void Open() { target=90; moving=true; }
    [ContextMenu("Close")] public void Close() { target=0; moving=true; }
    [ContextMenu("Stop")] public void Stop() { moving=false; }
}
