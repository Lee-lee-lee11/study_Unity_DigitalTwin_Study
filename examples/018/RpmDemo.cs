using UnityEngine;

public class RpmDemo : MonoBehaviour
{
    void Start() {
        foreach(float rpm in new[]{60f,120f,-30f})
            Debug.Log($"{rpm} RPM = {rpm*6f} deg/s");
    }
}
