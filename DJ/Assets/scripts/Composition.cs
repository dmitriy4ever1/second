using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Composition : MonoBehaviour {

    public string name;
    public string genre;
    public AudioClip clip;


    void Start()
    {
        print("composition start");
    }

    // TODO: add Pause() / UnPause()
    public void Play()
    {
        PlayList.audioSrc.PlayOneShot(clip);
    }

    public void Stop()
    {
        PlayList.audioSrc.Stop();
    }

}
