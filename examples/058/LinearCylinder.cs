using UnityEngine;

public class LinearCylinder : MonoBehaviour
{
    public bool extended;
    public float stroke=.2f,speed=.1f;
    public Vector3 axis=Vector3.right;
    public float Position {get;private set;}
    Vector3 home;
    void Awake()=>home=transform.localPosition;
    void Update(){Position=Mathf.MoveTowards(Position,extended?Mathf.Max(0,stroke):0,Mathf.Max(0,speed)*Time.deltaTime);transform.localPosition=home+axis.normalized*Position;}
}
