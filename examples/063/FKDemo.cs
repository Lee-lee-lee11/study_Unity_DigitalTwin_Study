using UnityEngine;

public class FKDemo : MonoBehaviour
{
    public float l1=1,l2=1,q1,q2=90;
    void Start(){float a=q1*Mathf.Deg2Rad,b=(q1+q2)*Mathf.Deg2Rad;Debug.Log(new Vector2(l1*Mathf.Cos(a)+l2*Mathf.Cos(b),l1*Mathf.Sin(a)+l2*Mathf.Sin(b)));}
}
