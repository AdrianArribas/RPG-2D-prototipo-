using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warp : MonoBehaviour {

	public GameObject target;

	void Awake (){
		GetComponent <SpriteRenderer>().enabled = false;
		transform.GetChild (0).GetComponent <SpriteRenderer>().enabled = false;
	}

	void OnTriggerEnter2D(Collider2D Other){
		if (Other.tag == "Player") {
			Debug.Log ("Player dentro");
			Other.transform.position = target.transform.GetChild (0).transform.position; 
		}
	}
}
