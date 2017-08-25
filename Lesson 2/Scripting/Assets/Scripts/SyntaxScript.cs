using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SyntaxScript : MonoBehaviour {
    
	void Start () {
        Debug.Log(transform.position.x);

        if(transform.position.y <= 5)
        {
            Debug.Log("Yerdeyim!");
        }
	}
}
