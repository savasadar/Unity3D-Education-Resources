using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyMouseInput : MonoBehaviour {

    public GameObject otherGameObject;

	void Start () {
        GetComponent<MeshRenderer>().material.color = Color.red;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        Debug.Log("OnMouseDown");
        GetComponent<Rigidbody>().AddForce(Vector3.forward * 500f);
        otherGameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
    }
}
