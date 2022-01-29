using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private AudioSource AudioNotes;

    [Header("Массив нот")]
    [SerializeField] private AudioClip[] Notes = new AudioClip[7];

    void Start()
    {
        AudioNotes = GetComponent<AudioSource>();
    }

    public void PlaySound(int nuberNotes)
    {
        AudioNotes.PlayOneShot(Notes[nuberNotes]);
    }
}
