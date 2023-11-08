using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class worldPosStays : MonoBehaviour
{
    public bool stays;
    // Start is called before the first frame update
    void Start()
    {
        enabled = false;
        Debug.Log($"Parent is: {transform.parent}");
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.parent != null)
        {
            Debug.Log("Set");
            transform.SetParent(transform.parent, false);
        }
        Debug.Log($"Parent is: {transform.parent}");
    }
}
