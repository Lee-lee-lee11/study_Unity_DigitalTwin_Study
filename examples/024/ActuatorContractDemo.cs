using UnityEngine;
public interface IActuatorLesson24 { void StartMotion(); void StopMotion(); }
public class Motor24 : IActuatorLesson24 {
 public void StartMotion()=>Debug.Log("Motor start"); public void StopMotion()=>Debug.Log("Motor stop");
}
public class Cylinder24 : IActuatorLesson24 {
 public void StartMotion()=>Debug.Log("Cylinder extend"); public void StopMotion()=>Debug.Log("Cylinder stop");
}
public class ActuatorContractDemo : MonoBehaviour {
 void Start() { IActuatorLesson24[] devices={new Motor24(),new Cylinder24()}; foreach(var d in devices){d.StartMotion();d.StopMotion();} }
}
