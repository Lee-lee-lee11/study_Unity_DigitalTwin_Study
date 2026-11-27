using UnityEngine;

public class MoveDemo : MonoBehaviour
{
    Vector3 target;
    void Start()=>target=transform.position+Vector3.right*3;
    void Update()=>transform.position=Vector3.MoveTowards(transform.position,target,Time.deltaTime);
}
