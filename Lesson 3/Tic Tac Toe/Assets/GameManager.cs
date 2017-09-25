using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public string whoseTurn = "X";
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ChangeTurn()
    {
        if (whoseTurn == "X")
        {
            whoseTurn = "O";
        }
        else
        {
            whoseTurn = "X";
        }
    }
}
