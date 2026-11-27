using UnityEngine;

public class IKDemo : MonoBehaviour
{
    public Vector2 target=new Vector2(1,1);
    public float l1=1,l2=1;
    void Start(){if(l1<=0||l2<=0)return;
     float c=(target.sqrMagnitude-l1*l1-l2*l2)/(2*l1*l2);
     if(c < -1.00001f || c > 1.00001f){Debug.LogWarning("Unreachable");return;}
     foreach(int sign in new[]{1,-1}){float b=sign*Mathf.Acos(Mathf.Clamp(c,-1,1));float a=Mathf.Atan2(target.y,target.x)-Mathf.Atan2(l2*Mathf.Sin(b),l1+l2*Mathf.Cos(b));Debug.Log($"q1={a*Mathf.Rad2Deg}, q2={b*Mathf.Rad2Deg}");}}
}
