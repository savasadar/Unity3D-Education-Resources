using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoWhileLoop : MonoBehaviour {

    int count = 10;

    void Start () {
        do
        {
            Debug.Log("create enemy number:" + count);
            count--;
        } while (count > 5);
        
	}
}
