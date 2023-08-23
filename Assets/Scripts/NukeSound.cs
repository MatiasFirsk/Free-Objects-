using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NukeSound : MonoBehaviour
{
    public static NukeSound instance;

    public AudioSource sfxSource;
    public AudioClip nukeExplosionSound;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    public void PlaySound(AudioClip clip)
    {
        sfxSource.PlayOneShot(clip);
    }
}
