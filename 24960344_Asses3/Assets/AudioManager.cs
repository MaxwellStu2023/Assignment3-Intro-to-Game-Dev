using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("Audio Source")]
    [SerializeField] AudioSource BgmusicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("Audio Clips")]
    public AudioClip background;
    public AudioClip pelleteaten;
    public AudioClip powerpelleteaten;
    public AudioClip wallcollision;
    public AudioClip ghosteaten;
    public AudioClip movement;
    public AudioClip death;

    private void Start()
    {
        BgmusicSource.clip = background;
        BgmusicSource.Play();
    }
}

