using UnityEngine;

public class DoorDrive : MonoBehaviour
{
    public float min=0,max=90,speed=45,target;
    public Vector3 axis=Vector3.up;
    public float Angle {get;private set;}
    Quaternion closed;
    void Awake()=>closed=transform.localRotation;
    void Update(){if(axis.sqrMagnitude<1e-8f)return;
     Angle=Mathf.MoveTowards(Angle,Mathf.Clamp(target,min,max),Mathf.Max(0,speed)*Time.deltaTime);
     transform.localRotation=closed*Quaternion.AngleAxis(Angle,axis.normalized);}
    public void SetAngle(float value)=>target=Mathf.Clamp(value,min,max);
}
