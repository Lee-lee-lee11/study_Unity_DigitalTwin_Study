using UnityEngine;

public class RollerVisual : MonoBehaviour
{
    public float radius=.05f,speed=.2f;
    void Update(){if(radius>0)transform.Rotate(Vector3.up,speed/radius*Mathf.Rad2Deg*Time.deltaTime,Space.Self);}
}
