using System.ComponentModel;
public class MotorVm : INotifyPropertyChanged {
 public event PropertyChangedEventHandler? PropertyChanged;
 private double speed=60;
 public double MotorSpeed {get=>speed;set{if(speed==value)return;speed=value;PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(nameof(MotorSpeed)));}}
}
