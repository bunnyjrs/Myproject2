using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UnityEventOnTrigger : MonoBehaviour
{
    public UnityEvent onTriggerEnter, onTriggerExit;

    public string tagToActivate = "Player";
    public string tagToActivate2 = "Key";

    private void Awake()
    {
        if ((GetComponent<Collider>() == null) && (GetComponent<Collider2D>() == null))
        {
            Debug.Log($"{gameObject} is missing a collider");
        }
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(tagToActivate))
        {
            onTriggerEnter.Invoke();
            Debug.Log("Unity Event Trigger (enter) activated on " + gameObject);
        }
    }
    
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag(tagToActivate))
        {
            onTriggerExit.Invoke();
            Debug.Log("Unity Event Trigger (exit) activated on " + gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered");
        if (other.CompareTag(tagToActivate))
        {
            onTriggerEnter.Invoke();
            Debug.Log("Unity Event Trigger (enter) activated on " + gameObject);
        }

        Debug.Log($"Other tag: {other.tag}");
        Debug.Log($"Active: {tagToActivate2}");
        Debug.Log($"Other is: {other}");
        if (other.CompareTag(tagToActivate2))
        {
            onTriggerEnter.Invoke();
            Debug.Log("Unity Event Trigger (enter) activated on " + gameObject);
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(tagToActivate))
        {
            onTriggerExit.Invoke();
            Debug.Log("Unity Event Trigger (exit) activated on " + gameObject);
        }

        if (other.CompareTag(tagToActivate2))
        {
            onTriggerExit.Invoke();
            Debug.Log("Unity Event Trigger (exit) activated on " + gameObject);
        }
    }
}
