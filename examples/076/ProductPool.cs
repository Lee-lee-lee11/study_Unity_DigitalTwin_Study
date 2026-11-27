using UnityEngine;
using System.Collections.Generic;
public class ProductPool : MonoBehaviour
{
    public GameObject prefab;
    readonly Queue<GameObject> available=new Queue<GameObject>();readonly HashSet<GameObject> leased=new HashSet<GameObject>();
    void Start(){if(!prefab)return;for(int i=0;i<10;i++){var o=Instantiate(prefab,transform);o.SetActive(false);available.Enqueue(o);}}
    public GameObject Rent(Vector3 pos){if(available.Count==0)return null;var o=available.Dequeue();leased.Add(o);o.transform.position=pos;o.SetActive(true);return o;}
    public void Return(GameObject o){if(!leased.Remove(o))return;o.SetActive(false);available.Enqueue(o);}
}
