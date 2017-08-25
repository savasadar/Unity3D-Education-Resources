using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneScript : MonoBehaviour {

    int counter = 100;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        counter--;
        Debug.Log(counter);

        if (counter < 0)
        {
            GetComponent<MeshCollider>().enabled = false;
        }
	}
}
