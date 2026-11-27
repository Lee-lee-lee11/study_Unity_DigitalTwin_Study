using UnityEngine;

public class MotorController : MonoBehaviour
{
    public float rpm=60;
    public bool running=true;
    public Vector3 axis=Vector3.up;
    void Update(){if(running && axis.sqrMagnitude>0)transform.Rotate(axis.normalized,rpm*6f*Time.deltaTime,Space.Self);}
    public void Stop()=>running=false;
}
