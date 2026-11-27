using UnityEngine;

public class MotorObjectDemo : MonoBehaviour
{
    class MotorSettings { public float rpm; }
    void Start() {
        var a=new MotorSettings { rpm=60 }; var b=new MotorSettings { rpm=120 };
        a.rpm=30; Debug.Log($"A={a.rpm}, B={b.rpm}");
    }
}
