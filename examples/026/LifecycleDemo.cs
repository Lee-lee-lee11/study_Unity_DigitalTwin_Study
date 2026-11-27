using UnityEngine;

public class LifecycleDemo : MonoBehaviour
{
    Vector3 initial;
    void Awake(){initial=transform.localPosition;Debug.Log(name+" Awake");}
    void Start()=>Debug.Log(name+" Start: "+initial);
}
