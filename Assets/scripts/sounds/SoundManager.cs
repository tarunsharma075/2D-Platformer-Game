using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SoundManager : MonoBehaviour
{


    private static SoundManager instance;
    public static SoundManager Instance { get { return instance; } }
    
    public AudioSource SoundEffects;
    public AudioSource backgroundmusic;
    public soundtype[] Sounds;



    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    //this class is for speific sound type you want to play a particular sound
    [Serializable]
    public class soundtype
    {
        public sounds SoundType;
        public AudioClip SoundClip;
    }


    public void playmusc(sounds sound)
    {

        AudioClip clip = Getsoundclip(sound);
        if (clip != null) {

            backgroundmusic.clip= clip;
            backgroundmusic.Play();
        }
    }


    private void Start()
    {
        playmusc(sounds.background);
    }
    public void Play(sounds Sound)
    {

        AudioClip clip = Getsoundclip(Sound);

        if (clip != null)
        {
            SoundEffects.PlayOneShot(clip);
        }else
        {
            Debug.Log("Not found any sound");
        }
    }

    public  AudioClip Getsoundclip(sounds sound)
    {
        soundtype item = Array.Find(Sounds, i => i.SoundType == sound);
        if (item != null) {

            return item.SoundClip;
        }
        return null;
    }

    public enum sounds
    {
        ButtonClick,
        PlayerMove,
        PlayerDeath,
        background
       

    }
}
