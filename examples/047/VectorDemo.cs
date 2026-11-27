using UnityEngine;

public class VectorDemo : MonoBehaviour
{
    public Transform a,b;
    void Start(){if(!a||!b)return;Vector3 delta=b.position-a.position;Debug.Log($"delta={delta}, distance={delta.magnitude}, direction={delta.normalized}");}
}
