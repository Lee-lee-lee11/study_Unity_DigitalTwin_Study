using UnityEngine;

public class OrbitCamera : MonoBehaviour
{
    public Transform target;public float distance=5,yaw=45,pitch=30;
    void LateUpdate(){if(!target)return;if(Input.GetMouseButton(1)){yaw+=Input.GetAxis("Mouse X")*5;pitch-=Input.GetAxis("Mouse Y")*5;}
     pitch=Mathf.Clamp(pitch,-80,80);distance=Mathf.Clamp(distance-Input.mouseScrollDelta.y,1,20);
     Quaternion q=Quaternion.Euler(pitch,yaw,0);transform.SetPositionAndRotation(target.position-q*Vector3.forward*distance,q);}
}
