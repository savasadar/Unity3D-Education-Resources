using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomSliderScript : MonoBehaviour {

    public Text text;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        text.text = GetComponent<Slider>().value.ToString();
	}
}
