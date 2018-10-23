using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TouchZombieToLoadLevel2 : MonoBehaviour {


    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Here!!");
        SceneManager.LoadScene("Graveyard", LoadSceneMode.Single);
    }

}
