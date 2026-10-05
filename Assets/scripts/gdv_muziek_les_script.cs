using UnityEngine;

public class gdv_muziek_les_script : MonoBehaviour
{

    bool isPlaying;
    string current_song = "";
    public float startVolume = 1.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlaySong("song1");
        SetVolume(startVolume);
        Debug.Log("speelt er wat? " + isPlaying);
        StopSong();
        PlaySong("song2");
        GetCurrentSong();
        Debug.Log("is playing " + GetCurrentSong());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            PlaySong(current_song);
        }
    }

    void PlaySong(string songName)
    {
        Debug.Log("now playing " + songName);
        current_song = songName;
        isPlaying = true;
    }

    void StopSong()
    {
        Debug.Log(current_song + " is stopped");
        isPlaying = false;
    }

    void SetVolume(float volume)
    {
        if (volume >= 0 && volume <= 10)
        {
            Debug.Log("The volume is " + volume);
        }
        else
        {
            Debug.Log("volume must be between 0 and 10");
        }
    }

    string GetCurrentSong()
    {
        return current_song;
    }

    bool IsPlaying()
    {  
        return isPlaying;
    }
}
