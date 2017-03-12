using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMusic : MonoBehaviour
{

    public AudioSource audioSource;
    public AudioClip audioClip;

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            audioSource.clip = audioClip;
            audioSource.Play();
        }
    }
}