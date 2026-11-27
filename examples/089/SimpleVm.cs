public class SimpleVm { public string MotorName { get; set; } = "Motor 01"; }
// In MainWindow constructor after InitializeComponent(): DataContext = new SimpleVm();
// 90강에서 변경 알림 추가 전에는 다른 UI의 즉시 갱신이 보장되지 않는다.
