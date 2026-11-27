using UnityEngine;

public class ConditionalMotor : MonoBehaviour
{
    public bool running;
    public float rpm=30f;
    void Update() { if(running) transform.Rotate(0,rpm*6f*Time.deltaTime,0); }
}
