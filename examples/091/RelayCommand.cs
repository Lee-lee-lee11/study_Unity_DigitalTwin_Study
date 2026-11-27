using System;
using System.Windows.Input;
public sealed class RelayCommand : ICommand {
 readonly Action execute; readonly Func<bool> canExecute;
 public RelayCommand(Action execute,Func<bool> canExecute){this.execute=execute;this.canExecute=canExecute;}
 public event EventHandler? CanExecuteChanged;
 public bool CanExecute(object? p)=>canExecute();
 public void Execute(object? p){if(CanExecute(p))execute();}
 public void Refresh()=>CanExecuteChanged?.Invoke(this,EventArgs.Empty);
}
