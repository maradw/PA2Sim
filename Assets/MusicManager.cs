using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;



public class MusicManager : MonoBehaviour
{
    [SerializeField] private AudioInformation SetAudio;
    [SerializeField] private AudioMixer newSettAudio;

    public void Setmaster(float f)
    {
        SetAudio._Master = f;
        newSettAudio.SetFloat("Master", Mathf.Log10(f) * 20f);
    }
    public void SetSFX(float f)
    {
        SetAudio._SFX = f;
        newSettAudio.SetFloat("SFX", Mathf.Log10(f) * 20f);
    }
    public void SetMusic(float f)
    {
        SetAudio._Music = f;
        newSettAudio.SetFloat("Music", Mathf.Log10(f) * 20f);

    }
}
