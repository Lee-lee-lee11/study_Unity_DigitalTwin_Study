using UnityEngine;
using System.Collections.Generic;
public class ProductSpawner : MonoBehaviour
{
    public GameObject prefab;public float interval=2;public int maxActive=5;
    readonly List<GameObject> active=new List<GameObject>();float timer;
    void Update(){if(!prefab||interval<=0)return;active.RemoveAll(x=>!x);timer+=Time.deltaTime;if(timer<interval)return;timer=0;if(active.Count<maxActive)active.Add(Instantiate(prefab,transform.position,transform.rotation));}
}
