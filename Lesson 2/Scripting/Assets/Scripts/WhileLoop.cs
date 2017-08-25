using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoop : MonoBehaviour {

    int count = 10;

	void Start () {
        while (count > 0)
        {
            Debug.Log("create enemy number:" + count);
            count--;
        }	
	}
}
