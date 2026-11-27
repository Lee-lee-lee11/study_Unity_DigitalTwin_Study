using UnityEngine;
[System.Serializable] public class JointDto42 {
 public int schemaVersion; public string coordinateSystem,unit,partId,parentId;
 public Vector3 position,axis; public float limitMin,limitMax;
}
public class JointJsonReader : MonoBehaviour {
 public TextAsset json;
 void Start(){if(!json)return;var d=JsonUtility.FromJson<JointDto42>(json.text);
 if(d==null || d.schemaVersion!=1 || d.unit!="m" || d.coordinateSystem!="Unity" || string.IsNullOrEmpty(d.partId)||d.axis.sqrMagnitude<1e-8f||d.limitMin>d.limitMax){Debug.LogError("Invalid joint");return;}
 Debug.Log($"{d.partId}: axis={d.axis} limits={d.limitMin}..{d.limitMax}");}
}
