using UnityEngine;

public class Equipment66 : MonoBehaviour
{
    public string equipmentId="station-01";
    public enum State{Idle,Running,Fault}
    public State state;
    public MonoBehaviour[] actuators;
}
