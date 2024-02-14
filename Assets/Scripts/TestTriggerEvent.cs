using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TestTriggerEvent : MonoBehaviour
{

    public bool trigger = false;
    public UnityEvent events;

    void Start()
    {
        
    }

    void Update()
    {
        if (trigger) {
            events.Invoke();
            trigger = false;
        } else {

        }
    }
}
