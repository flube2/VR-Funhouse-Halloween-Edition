using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCoffinWithObject : MonoBehaviour {

    public GameObject doorClosed;
    public GameObject doorOpen;
    public AudioSource src;
    public AudioClip creak;

    void OnCollisionEnter(Collision col)
    {
        StartCoroutine(wait2seconds());
        doorOpen.SetActive(true);

    }


    IEnumerator wait2seconds() // Ironically I only wait 1.5 seconds
    {
        src.clip = creak;
        src.Play();
        yield return new WaitForSeconds(1.5f);
        doorClosed.SetActive(false);
    }




}
