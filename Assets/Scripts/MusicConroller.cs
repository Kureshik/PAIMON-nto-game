using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicConroller : MonoBehaviour
{
    AudioSource audioSource;
    [SerializeField] AudioClip[] musics;
    int nowIndex = 0;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = musics[0];
        audioSource.Play();
    }

    void Update()
    {
        if (!audioSource.isPlaying) NextMusic();
    }

    void NextMusic()
    {
        nowIndex++;
        if (nowIndex > musics.Length-1) nowIndex = 0;
        audioSource.clip = musics[nowIndex];
        audioSource.Play();
    }
}
