using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cherry : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D collision) {
		Debug.Log ("enter:" + collision.gameObject.name);
	}

	void OnCollisionStay2D(Collision2D collision) {
		Debug.Log ("stay:" + collision.gameObject.name);
	}

	void OnCollisionExit2D(Collision2D collision) {
		Debug.Log ("exit:" + collision.gameObject.name);
	}

	void OnTriggerEnter2D(Collider2D collider) {
		Debug.Log ("trigger enter:" + collider.gameObject.name);
	} 
}
