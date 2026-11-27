using UnityEngine;

public class ForceDemo : MonoBehaviour
{
    void Start(){GetComponent<Rigidbody>().AddForce(Vector3.right*2,ForceMode.Impulse);}
}
