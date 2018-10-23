using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meow : MonoBehaviour {

    public AudioSource src;
    public AudioClip meow1;
    public AudioClip meow2;
    public AudioClip categg;


    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Floor")
        {
            src.clip = meow2;
            src.Play();
        }
        else if (col.gameObject.tag == "Table" || col.gameObject.name == "Tabletop")
        {
            // Nothing, this would play on scene load
        }
        else if (col.gameObject.tag == "Torch")
        {
            src.clip = categg;
            src.Play();
        }
        else
        {
            // Debug.Log(col.gameObject.name);
            src.clip = meow1;
            src.Play();
        }
    }


}
