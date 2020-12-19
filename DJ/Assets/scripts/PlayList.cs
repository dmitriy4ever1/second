using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayList : MonoBehaviour {

    // create an array or a list of compositions (audio tracks)

    public static AudioSource audioSrc;     // acessible from other scripts

    public GameObject[] piece;
    private Composition song;
    public Text songNumText, songNameText;

    int sNum = 0;
    void Start()
    {
        songNumText.text = "song " + (sNum+1);

        print("Playlist init");
        if (audioSrc == null)
            audioSrc = gameObject.AddComponent<AudioSource>();

        print("player is: " + audioSrc);
        song = piece[sNum].GetComponent<Composition>();
        songNameText.text = "Song Name: " + song.name;

    }

    public void Next()
    {
        song.Stop();
        sNum++;
        if (sNum > piece.Length-1)
        {
            sNum = 0;
        }
        song = piece[sNum].GetComponent<Composition>();
        songNumText.text = "song " + (sNum + 1);
        songNameText.text = "Song Name: " + song.name;

        song.Play();

    }

    public void Prev()
    {
        song.Stop();
        sNum--;
        if (sNum < 0)
        {
            sNum = piece.Length-1;
        }
        song = piece[sNum].GetComponent<Composition>();
        songNumText.text = "song " + (sNum + 1);
        songNameText.text = "Song Name: " + song.name;

        song.Play();
    }
    bool isOn = false;
    public  void Toggle()
    {
        if (isOn == false)
        {
            isOn = true;
            song.Play();
        }
        else
        {
            isOn = false;
            song.Stop();
        }
    }

}
