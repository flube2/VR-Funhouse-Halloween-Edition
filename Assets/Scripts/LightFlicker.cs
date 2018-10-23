using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlicker : MonoBehaviour {

    private Light lightF;
    private GameObject go;

	// Use this for initialization
	void Start () {
        lightF = GameObject.FindGameObjectWithTag("FlickeringLight").GetComponent<Light>();
        lightF.intensity = 0.0f;
        go = GameObject.FindGameObjectWithTag("Patient");
        go.SetActive(false);
    }


    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Torch")
        {
                Debug.Log("Active!");
                go.GetComponent<AudioSource>().Play();
                StartCoroutine(lightFlicker(lightF));
        }
    }


    IEnumerator lightFlicker(Light light)
    {
        go.SetActive(true);
        bool active = true;
        for (int i = 0; i < 8; i++, active = !active)
        {
            if (active == true)
            {
                light.intensity = 3.0f;
            }
            else
            {
                light.intensity = 0.0f;
            }
            yield return new WaitForSeconds(0.25f);
        }
        go.SetActive(false);


    }
}
