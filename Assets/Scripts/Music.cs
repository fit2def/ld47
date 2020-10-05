using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    AudioClip music;
    AudioClip hellMusic;
    // Start is called before the first frame update
    void Start()
    {
        AudioSource sound = GetComponent<AudioSource>();

        sound.PlayOneShot(Levels.InHell() ? hellMusic : music);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
