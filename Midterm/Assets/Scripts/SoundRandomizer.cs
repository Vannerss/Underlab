using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundRandomizer : MonoBehaviour
{
    public AudioClip[] sounds;
    private AudioSource source;

    private void Start()
    {
        source = GetComponent<AudioSource>();
    }

    private void Update()
    {
        
    }
}
