using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySFX : MonoBehaviour {

    public AudioSource src;
    public AudioClip keydrop;
    public AudioClip coffinopen;

	// Use this for initialization
	void Start () {
		
	}
	
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Floor")
        {
            src.clip = keydrop;
            src.Play();
        }

        if (col.gameObject.name == "Coffin Door")
        {
            src.clip = coffinopen;
            src.Play();
            GameObject.Destroy(col.gameObject);
        }
    }

}
