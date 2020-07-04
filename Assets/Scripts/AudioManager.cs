using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public AudioSource[] music;
    public AudioSource[] sfx;

    public int levelMusicToPlay;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        PlayMusic(levelMusicToPlay);
    }

    public void PlayMusic(int musicToPlay)
    {
        for (int i = 0; i < music.Length; i++)
        {
            music[i].Stop();
        }

        music[musicToPlay].Play();
    }

    public void PlaySFX(int sfxToPlay)
    {
        sfx[sfxToPlay].Play();
    }
}
