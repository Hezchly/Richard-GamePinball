using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource bgmAudioSource;
    public GameObject sfxAudioSource;  // untuk Bumper
    public GameObject sfxAudioSource2; // untuk Switch on
    public GameObject sfxAudioSource3; // untuk Switch off

    // Start is called before the first frame update
    void Start()
    {
        PlayBGM();
    }

    public void PlayBGM()
    {
        bgmAudioSource.Play();
    }

    public void PlaysfxAudioSource(Vector3 spawnPosition)
    {
        GameObject.Instantiate(sfxAudioSource, spawnPosition, Quaternion.identity);
         
    }

    public void PlaysfxAudioSource2(Vector3 spawnPosition)
    {
        GameObject.Instantiate(sfxAudioSource2, spawnPosition, Quaternion.identity);
    }

    public void PlaysfxAudioSource3(Vector3 spawnPosition)
    {
        GameObject.Instantiate(sfxAudioSource3, spawnPosition, Quaternion.identity);
    }
}
