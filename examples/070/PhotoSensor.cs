using UnityEngine;

public class PhotoSensor : MonoBehaviour
{
    public float range=.5f;public LayerMask mask;public bool detected;public float distance;
    void FixedUpdate(){detected=Physics.Raycast(transform.position,transform.forward,out var hit,range,mask,QueryTriggerInteraction.Ignore);distance=detected?hit.distance:-1;Debug.DrawRay(transform.position,transform.forward*range,detected?Color.green:Color.red);}
}
