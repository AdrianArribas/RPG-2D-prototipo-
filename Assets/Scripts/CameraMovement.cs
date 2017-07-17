using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

	public Rigidbody2D rb2d;
	public float VelocidadCamara= 4f;
	Rigidbody cameraPos;
	Transform objetivo;
	bool seguir= false;
	// Use this for initialization
	void Start () {
		
		cameraPos = gameObject.GetComponent <Rigidbody> ();

	}
	
	// Update is called once per frame
	void Update () {
		
			Debug.Log ("Player fuera del aera");
			Vector3 v3 = new Vector3 (rb2d.position.x, rb2d.position.y, 0);
			cameraPos.MovePosition (v3 * VelocidadCamara * Time.deltaTime);

	}

	void OnTriggerExit (Collider campoCam){
		Debug.Log ("algo ha salido");
		if (campoCam.tag == "Player") {
			seguir = true;
		}



	}
}
