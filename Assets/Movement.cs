using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Animator myAnimator;
    // Start is called before the first frame update
    void Start()
    {
        myAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w") || Input.GetKey("a") || Input.GetKey("s") || Input.GetKey("d"))
        {
            myAnimator.SetFloat("Speed", 4);
        }
        else
        {
            myAnimator.SetFloat("Speed", 0);
        }
        if (Input.GetKey("space"))
        {
            myAnimator.SetBool("Jump", true);
        }
        else
        {
            myAnimator.SetBool("Jump", false);
        }
    }
}
