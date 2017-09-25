using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomButtonScript : MonoBehaviour {

	public void changeColorToRed()
    {
        var colors = GetComponent<Button>().colors;
        colors.normalColor = Color.red;
        GetComponent<Button>().colors = colors;
    }

    public void changeName(string name)
    {
        GetComponentInChildren<Text>().text = name;
    }
}
