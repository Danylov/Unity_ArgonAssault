using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
   private void OnParticleCollision(GameObject other)
   {
      Debug.Log($"Enemy {name}: I'm hited by {other.gameObject.name}!");
      Destroy(gameObject);
   }
}
