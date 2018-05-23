using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class MainMenu : MonoBehaviour {

    [SerializeField]
    private AudioClip clipIntro;
    [SerializeField]
    [Range(0, 1.0f)]
    private float vol = 0.5f;

    private AudioSource a;

    void Awake ()
    {
        a = this.GetComponent<AudioSource>();
        a.clip = clipIntro;
        a.loop = true;
        //a.Play();
    }
}
