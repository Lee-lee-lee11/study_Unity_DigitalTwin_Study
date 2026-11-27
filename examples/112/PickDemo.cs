using UnityEngine;

public class PickDemo : MonoBehaviour
{
    public Camera cam;public LayerMask mask=~0;
    void Update(){if(cam&&Input.GetMouseButtonDown(0)){var ray=cam.ScreenPointToRay(Input.mousePosition);if(Physics.Raycast(ray,out var hit,1000,mask)){var part=hit.collider.GetComponentInParent<PartId>();if(part)Debug.Log(part.id);}}}
}
