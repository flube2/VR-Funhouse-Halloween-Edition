using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpread : MonoBehaviour {

	public GameObject fire;
	public float timeInterval = 5.0f;
	private float time;
	public int spreadRadius;
	private Transform trans;
	public bool spread;

	/*My initial thoughts and approach for this:
	 * 
	 * keep track of time interval.
	 * when reached, use GameObject.Instantiate(objectToSpread)
	 * as for position, use random numbers 1<x<5 and use for vector coordinates fr random location
	 * the specific range is in Unity's game units
	 * */



	// Use this for initialization
	void Start () {

		trans = this.gameObject.GetComponent<Transform> ();
		time = timeInterval;


	}

	// Update is called once per frame
	void Update () {

		time -= Time.deltaTime;

		if (time < 0.0f && spread) {

			time = timeInterval;
			trans = this.gameObject.GetComponent<Transform> (); // in case position changed
			GameObject clone = Instantiate (fire, new Vector3 (Random.Range (trans.position.x - spreadRadius, trans.position.x + spreadRadius), trans.position.y, Random.Range (trans.position.z - spreadRadius, trans.position.z + spreadRadius)), trans.rotation) as GameObject;

		}

	}
}
