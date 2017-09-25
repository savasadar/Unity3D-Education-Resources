using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManagerScript : MonoBehaviour {

	Animator anim;

	void Start () {
		anim = GetComponent<Animator> ();
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			anim.SetBool ("Next", true);
		}
		else if (Input.GetKeyDown (KeyCode.LeftArrow))
			anim.SetBool ("Back", true);
		else {
			anim.SetBool ("Next", false);
			anim.SetBool ("Back", false);
		}

		if (Input.GetKeyDown (KeyCode.W)) {
			anim.SetTrigger ("Win");
		}
	}
}
