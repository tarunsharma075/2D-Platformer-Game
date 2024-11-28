using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class SoundManager : MonoBehaviour
{


    private static SoundManager _instance;
    public static SoundManager Instance { get { return _instance; } }
    
    public AudioSource SoundEffects;
    public AudioSource BackGroundMusic;
    public SoundType[] Sounds;



    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }


    

    //this class is for speific sound type you want to play a particular sound
    [Serializable]
    public class SoundType
    {
        public sounds Sounds;
        public AudioClip SoundClip;
    }


    public void PlayMusic(sounds sound)
    {

        AudioClip clip = GetSoundClips(sound);
        if (clip != null) {

            BackGroundMusic.clip= clip;
            BackGroundMusic.Play();
        }
    }


    private void Start()
    {
        PlayMusic(sounds.BackGround);
    }
    public void Play(sounds Sound)
    {

        AudioClip clip = GetSoundClips(Sound);

        if (clip != null)
        {
            SoundEffects.PlayOneShot(clip);
        }else
        {
            Debug.Log("Not found any sound");
        }
    }

    public  AudioClip GetSoundClips(sounds sound)
    {
        SoundType item = Array.Find(Sounds, i => i.Sounds == sound);
        if (item != null) {

            return item.SoundClip;
        }
        return null;
    }

    public enum sounds
    {
        ButtonClick,
        PlayerDeath,
        BackGround,
        keyCollection,
        Jump,
        StageClear,
        GameOver,
        Fall,
       

    }
}
