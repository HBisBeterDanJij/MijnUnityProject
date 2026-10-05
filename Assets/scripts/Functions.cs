using UnityEngine;

public class Functions : MonoBehaviour
{
    string currentSong;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlaySong("song 1");
        Debug.Log("the current song is: " + GetCurrentSong());
        SetVolume(5);
        IsPlaying(true);
        PlaySong("song 2");
        Debug.Log("the current song is: " + GetCurrentSong());
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void PlaySong(string songName)
    {
        Debug.Log("Is playing: " + songName);
        currentSong = songName;
    }

    void StopSong()
    {
    }

    void SetVolume(float volume)
    {
        Debug.Log("Volume set to: " + volume);
    }

    string GetCurrentSong()
    {
        return currentSong;
    }

    bool IsPlaying(bool value)
    {
        Debug.Log("Is playing: " + value);
        return value;
    }
}
