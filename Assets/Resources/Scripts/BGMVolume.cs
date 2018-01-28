﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class BGMVolume : MonoBehaviour {

    // Update is called once per frame
    void Update ()
    {
        GetComponent<AudioSource>().volume = VolumeController.bgmVolume;
    }
}