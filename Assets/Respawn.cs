using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Respawn : MonoBehaviour
{
    Vector3 Position;

    void Start()
    {
        Position = transform.position;
    }

    private void Update()
    {
        if (transform.position.y<-2)
        {
            transform.position = Position;
        }
    }
}