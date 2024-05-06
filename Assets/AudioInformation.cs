using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "AudioSave", menuName = "Audio/AudioInfo", order = 1)]
public class AudioInformation : ScriptableObject
{
    public float _Master = 1f;
    public float _Music = 1f;
    public float _SFX = 1f;
}
