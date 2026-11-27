using UnityEngine;

public class Gripper79 : MonoBehaviour
{
    public Transform grip;Transform held,originalParent;
    public bool Grab(Transform product){if(!grip||!product||held)return false;held=product;originalParent=held.parent;held.SetParent(grip,true);return true;}
    public void Release(){if(!held)return;held.SetParent(originalParent,true);held=null;}
}
