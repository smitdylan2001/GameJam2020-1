using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource background;
    public AudioSource sfx1;
    public AudioSource sfx2;
    public AudioSource sfx3;

    public void ChangeMusic(float volume)
    {
        background.volume = volume;
    }
    public void ChangeSFX(float volume)
    {
        sfx1.volume = volume /100 * 45;
        sfx2.volume = volume / 100 * 80;
        sfx3.volume = volume / 100 * 80;
    }
}
