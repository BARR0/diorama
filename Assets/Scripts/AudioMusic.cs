using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class AudioMusic : MonoBehaviour
{
    public AudioClip otherClip;
    private AudioSource audio;

    // IEnumerator Start()
    // {
    //     audio = GetComponent<AudioSource>();

    //     audio.Play();
    //     yield return new WaitForSeconds(audio.clip.length);
    //     audio.clip = otherClip;
    //     audio.Play();
    // }

    // public static IEnumerator FadeOut (AudioSource audioSource, float FadeTime) {
    //     float startVolume = audioSource.volume;
 
    //     while (audioSource.volume > 0) {
    //         audioSource.volume -= startVolume * Time.deltaTime / FadeTime;
 
    //         yield return null;
    //     }
 
    //     audioSource.Stop ();
    //     audioSource.volume = startVolume;
    // }

    // public void FadeMain() {
    //     audio = GetComponent<AudioSource>();
    //     StartCoroutine (FadeOut (audio, 1.0f));
    // }

    // public void PlayGoodMusic() {
    //     audio = GetComponent<AudioSource>();
    //     audio.clip = goodClip;
    //     audioSource.volume = 1.0;
    //     audio.Play();
    // }

    public void PlayGongBad() {
        audio = GetComponent<AudioSource>();
        // audio.clip = otherClip;
        // audio.volume = 1.0f;
        audio.Play();
    }
}