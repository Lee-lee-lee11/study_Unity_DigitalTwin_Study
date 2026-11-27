using UnityEngine;

public class DigitalSensor : MonoBehaviour
{
    public bool Value {get;private set;}
    public event System.Action<bool> OnChanged;
    public void SetValue(bool next){if(Value==next)return;Value=next;OnChanged?.Invoke(next);}
    void Start(){OnChanged+=v=>Debug.Log(v);SetValue(true);SetValue(true);SetValue(false);}
}
