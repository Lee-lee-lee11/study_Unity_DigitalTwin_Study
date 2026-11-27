using UnityEngine;
using System.Collections.Generic;
public class TriggerSensor : MonoBehaviour
{
    readonly HashSet<Collider> inside=new HashSet<Collider>();
    public bool detected;
    void OnTriggerEnter(Collider other)=>inside.Add(other);
    void OnTriggerExit(Collider other)=>inside.Remove(other);
    void FixedUpdate(){inside.RemoveWhere(c=>!c||!c.enabled||!c.gameObject.activeInHierarchy);detected=inside.Count>0;}
    void OnDisable(){inside.Clear();detected=false;}
}
