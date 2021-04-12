using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public AudioSource background;
    public AudioSource sfx1;
    public AudioSource sfx2;
    public AudioSource sfx3;
    public Slider backgroundSlider;
    public Slider sfxSlider;
    //TODO improve only when changing slider
    // Update is called once per frame
    void Update()
    {
        background.volume = backgroundSlider.value;
        sfx1.volume = sfxSlider.value;
        sfx2.volume = sfxSlider.value;
        sfx3.volume = sfxSlider.value;
    }
}
