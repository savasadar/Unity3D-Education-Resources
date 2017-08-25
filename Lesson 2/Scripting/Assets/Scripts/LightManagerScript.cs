using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightManagerScript : MonoBehaviour {

    public float speed = 8f;
    public float countDown = 3.0f;

	void Update () {
        countDown -= Time.deltaTime;
        if (countDown <= 0)
        {
            GetComponent<Light>().color = Color.red;
            //GetComponent<Light>().enabled = false;
        }

        Debug.Log(countDown);

	}
}
