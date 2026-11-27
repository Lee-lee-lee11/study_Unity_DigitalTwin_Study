using UnityEngine;

public class TickDemo : MonoBehaviour
{
    int frames,physicsTicks; float elapsed;
    void FixedUpdate()=>physicsTicks++;
    void Update(){frames++;elapsed+=Time.unscaledDeltaTime;
     if(elapsed>=1){Debug.Log($"Update={frames}, Fixed={physicsTicks}");frames=physicsTicks=0;elapsed=0;}}
}
