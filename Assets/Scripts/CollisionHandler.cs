using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] float loadDelay = 1.0f; 
    [SerializeField] ParticleSystem crashVFX; 
    
    void OnTriggerEnter(Collider other)
     {
         if (!other.CompareTag("Terrain"))  StartCrashSequence();
     }

     void StartCrashSequence()
     {
         crashVFX.Play();
         GetComponent<MeshRenderer>().enabled = false;
         GetComponent<PlayerControls>().enabled = false;
         GetComponent<BoxCollider>().enabled = false;
         Invoke("ReloadLevel", loadDelay);
     }

     void ReloadLevel()
     {
         int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
         SceneManager.LoadScene(currentSceneIndex);
     }
}
