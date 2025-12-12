using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    public Collectible ears;
    public AudioSource music;

    void Start()
    {
        music.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (ears.isCollected)
        {
            music.enabled = true;
        }
    }
}
