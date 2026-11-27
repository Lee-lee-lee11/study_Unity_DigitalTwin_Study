using UnityEngine;

public class HingeTestTorque : MonoBehaviour
{
    void FixedUpdate(){GetComponent<Rigidbody>().AddTorque(transform.up*2f,ForceMode.Force);}
}
