using UnityEngine;
[System.Serializable] public class MotorData25 { public float rpm=60; }
public class MotorBehaviour25 : MonoBehaviour {
 [SerializeField] MotorData25 data=new MotorData25();
 void Start()=>Debug.Log(data.rpm);
}
