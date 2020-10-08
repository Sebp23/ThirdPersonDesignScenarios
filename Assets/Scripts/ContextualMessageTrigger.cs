using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContextualMessageTrigger : MonoBehaviour
{
    //delegate is a special type that defines a variable that can store a function to be used later (like when an event happens :O)
    public delegate void ContextualMessageTriggeredAction();

    public static event ContextualMessageTriggeredAction ContextualMessageTriggered;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (ContextualMessageTriggered != null)
            {
                ContextualMessageTriggered.Invoke();
            }
        }
    }
}
