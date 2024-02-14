using UnityEngine;
using System.Collections;
using System.Collections.Generic;
 
public class TriggerEvent : MonoBehaviour {
 
    public List<GameObject> items;
   
    void OnTriggerEnter(Collider other) {
       
        if (!items.Contains(other.gameObject))
        {
            items.Add(other.gameObject);
        }
       
    }
}