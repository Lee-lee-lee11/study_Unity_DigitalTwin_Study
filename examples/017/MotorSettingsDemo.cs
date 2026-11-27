using UnityEngine;

public class MotorSettingsDemo : MonoBehaviour
{
    [SerializeField] float rpm = 60f;
    [SerializeField] bool running;
    [SerializeField] int count;
    void Start() => Debug.Log($"{rpm} RPM, running={running}, count={count}");
}
