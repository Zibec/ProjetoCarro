using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Colisão hein!");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Square"))
        {
            Debug.Log("Bateu, eita porra!");
        }
    }
}
