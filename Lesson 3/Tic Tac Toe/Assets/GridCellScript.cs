using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridCellScript : MonoBehaviour {
    
    GameManager gameManager;

	void Start () {
        gameManager = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void mButtonClick()
    {
        GetComponentInChildren<Text>().text = gameManager.whoseTurn;
        gameManager.ChangeTurn();
    }
}
