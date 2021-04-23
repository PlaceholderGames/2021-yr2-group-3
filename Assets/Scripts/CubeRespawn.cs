using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRespawn : MonoBehaviour
{

    Vector3 startingPosition;
    // Start is called before the first frame update
    void Start()
    {
        startingPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -15)
        {
            transform.position = startingPosition;
        }
    }
}
