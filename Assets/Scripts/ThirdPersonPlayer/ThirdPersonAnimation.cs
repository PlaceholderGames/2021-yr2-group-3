using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonAnimation : MonoBehaviour
{

    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            anim.Play("Walking");
        }
        else if (Input.GetKeyDown("s"))
        {
            anim.Play("Walking");
        }
        else if (Input.GetKeyDown("a"))
        {
            anim.Play("Walking");
        }
        else if (Input.GetKeyDown("d"))
        {
            anim.Play("Walking");
        }
        else if (Input.anyKey == false)
        {
            anim.Play("Idle");
        }
    }
}
