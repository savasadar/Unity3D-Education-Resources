using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public StoneScript[] pointStones = new StoneScript[9];
	public StoneScript.TYPE whosTurn = StoneScript.TYPE.P1;
	public int p1Score = 0;
	public int p2Score = 0;

	public static GameManager instance;

	void Awake(){
		if (instance == null) {
			instance = this;
		} else if(instance != this) {
			Destroy (gameObject);
		}

		DontDestroyOnLoad (gameObject);
	}

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (checkSameStone(0,1,2)) {
			gameOver (pointStones [0].type);
		}
		else if (checkSameStone(3,4,5)) {
			gameOver (pointStones [3].type);
		}
		else if (checkSameStone(6,7,8)) {
			gameOver (pointStones [6].type);
		}
		else if (checkSameStone(0,3,6)) {
			gameOver (pointStones [0].type);
		}
		else if (checkSameStone(1,4,7)) {
			gameOver (pointStones [1].type);
		}
		else if (checkSameStone(2,5,8)) {
			gameOver (pointStones [2].type);
		}
		else if (checkSameStone(0,4,8)) {
			gameOver (pointStones [0].type);
		}
		else if (checkSameStone(2,4,6)) {
			gameOver (pointStones [2].type);
		}
	}

	private bool checkSameStone(int first, int second, int third){
		if (pointStones [first] == null || pointStones [second] == null || pointStones [third] == null)
			return false;

		if (pointStones [first].type == pointStones [second].type &&
			pointStones [second].type == pointStones [third].type) {
			return true;
		}

		return false;
	}

	private void gameOver(StoneScript.TYPE type){
		//skoru artır
		if (type == StoneScript.TYPE.P1)
			p1Score++;
		else
			p2Score++;

		//tüm objeler ilk noktalarına gidecek
		for (int i = 0; i < pointStones.Length; i++) {
			if (pointStones [i] == null)
				continue;
			
			pointStones [i].reset ();
			pointStones [i] = null;
		}
	}

	public void changeTurn(){
		if (whosTurn == StoneScript.TYPE.P1)
			whosTurn = StoneScript.TYPE.P2;
		else
			whosTurn = StoneScript.TYPE.P1;	
	}

	public bool wasTaken(int pointNumber){
		if (pointNumber > 9 || pointNumber < 1)
			return true;

		if (pointStones [pointNumber-1] == null)
			return false;
		else
			return true;
	}

	public void setPointStone(int pointNumber, StoneScript stone){
		if (pointNumber > 9 || pointNumber < 1)
			return;
		
		pointStones [pointNumber - 1] = stone;
	}

	public void clearPointStone(int pointNumber){
		if (pointNumber > 9 || pointNumber < 1)
			return;

		pointStones [pointNumber - 1] = null;
	}
}
