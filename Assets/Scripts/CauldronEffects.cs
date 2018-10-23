using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CauldronEffects : MonoBehaviour {

    public AudioSource src;
    public AudioClip clip;
    public GameObject emittance;

    void OnTriggerEnter()
    {
        src.clip = clip;
        src.Play();
        emittance.SetActive(true);
    }

    void OnTriggerExit()
    {
        src.Stop();
        emittance.SetActive(false);
    }


}
