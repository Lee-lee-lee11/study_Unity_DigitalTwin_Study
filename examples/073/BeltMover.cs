using UnityEngine;

public class BeltMover : MonoBehaviour
{
    public bool running=true;public float speed=.2f,length=2;
    Vector3 home;float position;
    void Start()=>home=transform.position;
    void Update(){if(!running)return;position=Mathf.MoveTowards(position,length,Mathf.Max(0,speed)*Time.deltaTime);transform.position=home+Vector3.right*position;}
}
