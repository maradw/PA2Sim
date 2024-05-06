using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuteAudio : MonoBehaviour
{
    //[SerializeField] private Camera m_camera;
    [SerializeField] private AudioListener myAudioList;
    bool enable = true;
    private void Start()
    {
        //m_camera = m_camera.GetComponent<AudioListener>();
    }
    private void Update()
    {
        //if(enable )
    }
    public void AudioListenerControl()
    {
        if (enable)
        {
            
            myAudioList.enabled = false;
            enable = false;
        }
        else
        {
            enable = true;
            myAudioList.enabled = true; 
        }
    }


}
