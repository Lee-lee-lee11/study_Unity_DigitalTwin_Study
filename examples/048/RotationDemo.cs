using UnityEngine;

public class RotationDemo : MonoBehaviour
{
    void Start(){Quaternion initial=transform.localRotation;transform.localRotation=initial*Quaternion.AngleAxis(90,Vector3.up);}
}
