using UnityEngine;
using System.Collections.Generic;
public class AssemblyDemo43 : MonoBehaviour
{
    public Transform root,hinge,door;
    void Start(){if(!root||!hinge||!door)return;
     var parts=new Dictionary<string,Transform>{{"root",root},{"hinge",hinge},{"door",door}};
     parts["hinge"].SetParent(parts["root"],false); hinge.localPosition=new Vector3(0,.5f,0);
     parts["door"].SetParent(parts["hinge"],false); door.localPosition=new Vector3(.5f,0,0);
    }
}
