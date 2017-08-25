using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyButtonInputScript : MonoBehaviour {
    
	void Update () {
        bool Zıpla = Input.GetButtonDown("Zıpla");
        bool enter = Input.GetButtonDown("Submit");
        bool cancel = Input.GetButtonDown("Cancel");

        if (Zıpla)
            Debug.Log("Zıpla");
        if (enter)
            Debug.Log("enter");
        if (cancel)
            Debug.Log("cancel");


        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Debug.Log("horizontal: " + horizontal);
        Debug.Log("vertical: " + vertical);

        transform.position = new Vector3(horizontal * 20, 2, 0);
    }
}
