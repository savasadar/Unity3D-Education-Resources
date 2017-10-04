using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IndicatorManager : MonoBehaviour {

	public Text turnText;
	public Text scoreP1Text;
	public Text scoreP2Text;

	GameManager gameManager;

	void Start () {
		gameManager = GameObject.FindWithTag ("GameManager").GetComponent<GameManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		turnText.text = gameManager.whosTurn.ToString ();
		scoreP1Text.text = gameManager.p1Score.ToString ();
		scoreP2Text.text = gameManager.p2Score.ToString ();
	}
}
