using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatement : MonoBehaviour {

    float coffeeTemp = 99.0f;
    float hotLimitTemp = 70.0f;
    float coldLimitTemp = 40.0f;
    
	void Update () {
        if(Input.GetKeyDown(KeyCode.Space))
            TempTest();

        coffeeTemp -= Time.deltaTime;
	}

    private void TempTest()
    {
        if (coffeeTemp > hotLimitTemp)
        {
            Debug.Log("kahve çok sıcak");
        }
        else if (coffeeTemp < coldLimitTemp)
        {
            Debug.Log("kahve çok soguk");
        }
        else
        {
            Debug.Log("kahve hazır");
        }
    }
}
