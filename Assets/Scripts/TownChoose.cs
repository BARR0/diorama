using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TownChoose : MonoBehaviour
{
    public Animator animator;
    // private bool good;
    public Canvas canvas;
    public Button bg, be;

    public AudioClip otherClip, goodClip, badClip;
    private AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        // good = true;
        canvas.gameObject.SetActive(false);
        bg.onClick.AddListener(SetGood);
        be.onClick.AddListener(SetEvil);
    }

    // Update is called once per frame
    void Update()
    {
        
        // animator.SetBool("good", good);
    }

    public void ShowButtons () {
        canvas.gameObject.SetActive(true);
    }

    public void HideButtons () {
        canvas.gameObject.SetActive(false);
    }

    public void SetGood () {
        animator.SetTrigger("good");
        PlayGoodMusic();
    }

    public void SetEvil () {
        animator.SetTrigger("evil");
        PlayEvilMusic();
    }

    // IEnumerator Start()
    // {
    //     audio = GetComponent<AudioSource>();

    //     audio.Play();
    //     yield return new WaitForSeconds(audio.clip.length);
    //     audio.clip = otherClip;
    //     audio.Play();
    // }

    public static IEnumerator FadeOut (AudioSource audioSource, float FadeTime) {
        float startVolume = audioSource.volume;
 
        while (audioSource.volume > 0) {
            audioSource.volume -= startVolume * Time.deltaTime / FadeTime;
 
            yield return null;
        }
 
        audioSource.Stop ();
        audioSource.volume = startVolume;
    }

    public void FadeMain() {
        audio = GetComponent<AudioSource>();
        StartCoroutine (FadeOut (audio, 2.0f));
    }

    public void PlayGoodMusic() {
        audio = GetComponent<AudioSource>();
        audio.clip = goodClip;
        audio.volume = 1.0f;
        audio.Play();
    }

    public void PlayEvilMusic() {
        audio = GetComponent<AudioSource>();
        audio.clip = badClip;
        audio.volume = 1.0f;
        audio.Play();
    }

    public void PlayGong() {
        audio = GetComponent<AudioSource>();
        audio.clip = otherClip;
        audio.volume = 1.0f;
        audio.Play();
    }
}
