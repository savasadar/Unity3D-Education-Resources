using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomTextScript : MonoBehaviour {

	public void setValue(Slider slider)
    {
        GetComponent<Text>().text = slider.value.ToString();
    }
}
