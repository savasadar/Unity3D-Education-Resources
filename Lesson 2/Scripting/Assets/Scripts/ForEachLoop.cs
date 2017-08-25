using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForEachLoop : MonoBehaviour {

    public int myInt = 5;

	void Start () {
        string[] strings = new string[3];

        strings[0] = "1. eleman";
        strings[1] = "2. eleman";
        strings[2] = "3. eleman";

        foreach (var item in strings)
        {
            Debug.Log("create enemy number:" + item);
        }
    }
}
