using UnityEngine;

public class LoopDemo : MonoBehaviour
{
    void Start() {
        for(int i=0;i<5;i++) Debug.Log(i);
        int j=0; while(j<3) { Debug.Log($"while {j}"); j++; }
    }
}
