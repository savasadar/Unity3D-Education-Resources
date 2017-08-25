using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScript2 : MonoBehaviour {

    int myInt = 5;

    private void Start()
    {
        myInt = multiplyByTwo(myInt);
        Debug.Log(myInt);
    }

    private int multiplyByTwo(int mInt)
    {
        int ret;

        ret = mInt * 2;

        return ret;
    }
}
