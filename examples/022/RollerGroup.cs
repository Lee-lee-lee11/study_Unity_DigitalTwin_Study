using UnityEngine;
using System.Collections.Generic;
public class RollerGroup : MonoBehaviour
{
    public List<Transform> rollers = new List<Transform>();
    void Update() { foreach(var r in rollers) if(r) r.Rotate(0,0,90*Time.deltaTime); }
}
