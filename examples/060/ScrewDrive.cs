using UnityEngine;

public class ScrewDrive : MonoBehaviour
{
    public Transform shaft,carriage;
    public float lead=.005f,rpm=120,stroke=.2f;
    float position; Vector3 home;
    void Start(){if(carriage)home=carriage.localPosition;}
    void Update(){if(!shaft||!carriage||lead<=0)return;
     float next=Mathf.Clamp(position+lead*rpm/60*Time.deltaTime,0,stroke);
     shaft.Rotate(Vector3.right,(next-position)/lead*360,Space.Self);
     position=next;carriage.localPosition=home+Vector3.right*position;}
}
