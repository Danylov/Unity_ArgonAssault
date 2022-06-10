using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    void Awake()
    {
        var numMusicPlayers = FindObjectsOfType<MusicPlayer>().Length;
        if (1 < numMusicPlayers) Destroy(gameObject);
        else DontDestroyOnLoad(gameObject);
    }
}
