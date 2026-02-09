using System.Collections.Generic;
using UnityEngine;


public static class obj 
{
    private static Dictionary<string, GameObject> map = new();


    public static GameObject Get(string name) {

        map.TryGetValue(name, out var obj);
        return obj;
    }
    public static T Get<T>(string name) where T : Component
    {
        if(map.TryGetValue(name, out var obj))
        return obj.GetComponent<T>();


        return null;
    }
 

    public static void Set(GameObject ob) { 
    
       map[ob.name] = ob;
       
    }

}
