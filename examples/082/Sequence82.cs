using UnityEngine;

public class Sequence82 : MonoBehaviour
{
    public bool detected,forward,back;public bool beltOn,extend;
    public enum Step{Feed,Extend,Retract,Fault} public Step step;
    public float timeout=5;float elapsed;
    void Go(Step s){step=s;elapsed=0;}
    void Update(){elapsed+=Time.deltaTime;beltOn=step==Step.Feed;extend=step==Step.Extend;
     switch(step){case Step.Feed: if(detected)Go(Step.Extend);break;case Step.Extend: if(forward)Go(Step.Retract);else if(elapsed>timeout)Go(Step.Fault);break;case Step.Retract: if(back)Go(Step.Feed);else if(elapsed>timeout)Go(Step.Fault);break;}
     if(step==Step.Fault){beltOn=false;extend=false;}}
}
