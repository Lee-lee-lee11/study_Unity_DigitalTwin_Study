using UnityEngine;
using System.Collections;
public class DoorDelay : MonoBehaviour
{
    IEnumerator Start(){yield return new WaitForSeconds(1f);transform.localRotation*=Quaternion.AngleAxis(90,Vector3.up);}
}
