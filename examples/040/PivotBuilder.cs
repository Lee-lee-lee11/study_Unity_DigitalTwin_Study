using UnityEngine;

public class PivotBuilder : MonoBehaviour
{
    public Transform mesh;
    public Vector3 anchor;
    public Vector3 axis=Vector3.up;
    void Start(){
     if(!mesh || axis.sqrMagnitude<1e-8f){Debug.LogError("Invalid mesh/axis");return;}
     var pivot=new GameObject("HingePivot").transform;
     pivot.SetParent(mesh.parent,true);pivot.position=anchor;
     pivot.rotation=Quaternion.FromToRotation(Vector3.up,axis.normalized);
     mesh.SetParent(pivot,true);
    }
}
