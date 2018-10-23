using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NunEyes : MonoBehaviour {

    public GameObject leftEye;
    public GameObject rightEye;
    public AudioSource src;
    public AudioClip clip;


    void OnTriggerEnter()
    {
        src.clip = clip;

        src.Play();
        leftEye.SetActive(true);
        rightEye.SetActive(true);
    }


    void OnTriggerExit()
    {
        src.Stop();
        leftEye.SetActive(false);
        rightEye.SetActive(false);
    }



}
