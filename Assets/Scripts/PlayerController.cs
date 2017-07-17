using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class PlayerController : MonoBehaviour {
	
	public float MoveSpeed = 4f;
	Animator anim;
	Rigidbody2D rb2d;
	Vector2 mov;
	// Use this for initialization
	void Start () {
		anim = GetComponent <Animator> ();
		rb2d = GetComponent <Rigidbody2D> ();	
	}

	// Update is called once per frame
	void Update () {

		//----------------------CAPTURAMOS EL INPUT EN UN VECTOR---------------------------------
		mov = new Vector2(Input.GetAxis ("Horizontal"),Input.GetAxis ("Vertical"));

		/*----------------------MOVIMIENTRO A TRAVES DE TRANSFORM Y VECTOR3-------------------------------
		Vector3 mov = new Vector3 (Input.GetAxis ("Horizontal"), Input.GetAxis ("Vertical"), 0);
		transform.position = Vector3.MoveTowards (transform.position, transform.position + mov, MoveSpeed * Time.deltaTime);
		----------------------------------------------------------------------------------------*/



		//----------------------ANIMACIONES------------------------------------------------------

		if (mov != Vector2.zero) {
			anim.SetFloat ("movX", mov.x);
			anim.SetFloat ("MovY", mov.y);
			anim.SetBool ("walking", true);
		} else {
			anim.SetBool ("walking",false);
		}
	}

	void FixedUpdate(){ //mas eficiente para movimientos y fisicas, mejora el framerate

		//--------------------MOVIMIENTO A TRAVES DE RIGIBODY-----------------------------------
		rb2d.MovePosition (rb2d.position + mov * MoveSpeed * Time.deltaTime);
	}


}
