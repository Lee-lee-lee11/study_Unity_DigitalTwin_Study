using UnityEngine;

public class RouteSelector : MonoBehaviour
{
    public Transform exitA,exitB;
    public Transform Select(string type){switch(type){case "A":return exitA;case "B":return exitB;default:Debug.LogError("Unknown type");return null;}}
}
