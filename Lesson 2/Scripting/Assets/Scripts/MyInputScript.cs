using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyInputScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        bool down = Input.GetKeyDown(KeyCode.Space);
        bool held = Input.GetKey(KeyCode.Space);
        bool up = Input.GetKeyUp(KeyCode.Space);

        if (down)
            Debug.Log("down");
        if (held)
            Debug.Log("held");
        if (up)
            Debug.Log("up");
    }
}
