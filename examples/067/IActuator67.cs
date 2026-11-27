public interface IActuator67 { void Move(float target); void Stop(); bool IsBusy{get;} }
public class MockActuator67 : IActuator67 {
 public float Target{get;private set;} public bool IsBusy{get;private set;}
 public void Move(float target){Target=target;IsBusy=true;} public void Stop(){IsBusy=false;}
 public void Complete(){IsBusy=false;}
}
