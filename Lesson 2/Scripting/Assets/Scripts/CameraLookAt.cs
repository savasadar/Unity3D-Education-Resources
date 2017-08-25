using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLookAt : MonoBehaviour {

    public Transform target;
    
	void Update () {
        transform.LookAt(target);

        transform.position = new Vector3(target.position.x - 2, target.position.y + 2);
	}
}
