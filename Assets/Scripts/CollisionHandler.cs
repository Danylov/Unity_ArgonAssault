using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        Debug.Log($"Object {name}: I'm collided by {other.gameObject.name}!");
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log($"Object {name}: I'm triggered by {other.gameObject.name}!");
    }
}
