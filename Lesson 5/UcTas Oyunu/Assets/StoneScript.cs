using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneScript : MonoBehaviour {

	public enum TYPE {P1, P2};

	public TYPE type = TYPE.P1;
	public Sprite p1;
	public Sprite p2;
	public GameObject[] points;

	int currPointNumber = 0;
	Vector3 firstClickPosition;
	Vector3 spawnPosition;
	bool isMoving = false;
	GameManager gameManager;

	void Start () {
		if(type == TYPE.P1)
			GetComponent<SpriteRenderer> ().sprite = p1;
		else
			GetComponent<SpriteRenderer> ().sprite = p2;

		gameManager = GameObject.FindWithTag ("GameManager").GetComponent<GameManager> ();

		spawnPosition = transform.position;
	}

	void Update () {

		//sıra bu taşta degilse inputlar kontrol edilmesin.
		if (gameManager.whosTurn != type) {
			return;
		}

		//Drag and Drop
		if (Input.GetMouseButtonDown (0)) {
			Collider2D hit = checkTouch ();
			if (hit != null && hit.gameObject.Equals (gameObject)) {
				isMoving = true;	
			}
		} 
		else if (Input.GetMouseButtonUp (0)) {
			Collider2D hit = checkTouch ();
			if (hit != null && hit.gameObject.Equals (gameObject)) {
				isMoving = false;	
				PutToPoint (Input.mousePosition);
			}
		}

		if (isMoving) {
			Vector3 mPos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			mPos.z = -10;
			gameObject.transform.position = mPos;
		}
	}

	private Collider2D checkTouch(){
		Ray ray = Camera.main.ScreenPointToRay( Input.mousePosition );
		RaycastHit2D hit = Physics2D.Raycast(new Vector2(ray.origin.x, ray.origin.y), Vector2.zero, 1.0f);
			
		if (hit.collider != null)
			Debug.Log (hit.collider.gameObject.name);
		else
			Debug.Log ("null");

		return hit.collider;
	}

	private void PutToPoint(Vector2 position){
		Vector2 mPos = Camera.main.ScreenToWorldPoint (position);

		float height = Camera.main.orthographicSize * 2;
		float width = height * Screen.width / Screen.height;

		int y = 1;
		int x = 1;

		if (Mathf.Abs(mPos.y) < width / 5) {
			//y 2. bölgede
			y = 2;
		}
		else if (mPos.y > 0) {
			//y 3. bölgede
			y = 3;
		}
		else {
			//y 1. bölgede
			y = 1;
		}

		if(Mathf.Abs(mPos.x) < width / 5) {
			//x 2. bölgede
			x = 2;
		}
		else if (mPos.x > 0) {
			//x 3. bölgede
			x = 3;
		}
		else {
			//x 1. bölgede
			x = 1;
		}

		int pointNumber = getPointNumber (x, y);

		//üzerine bırakılan noktada başka bir taş var mı kontrolü
		bool wasTaken = gameManager.wasTaken(pointNumber);

		if (wasTaken) {
			
			Vector3 oldPos;
			if (currPointNumber == 0) {
				//ilk yerine geri dönecek
				oldPos = spawnPosition;
			} else {
				//bu alanda başka bir taş var - dolu
				//eski yerine geri dönecek
				oldPos = points [currPointNumber - 1].transform.position;
			}

			oldPos.z = -5;
			gameObject.transform.position = oldPos;
			return;
		}

		//set stone position
		Vector3 newPos = points[pointNumber-1].transform.position;
		newPos.z = -5;
		gameObject.transform.position = newPos;
		//objeyi point stones dizisinde ilgili yere yerleştir
		gameManager.setPointStone (pointNumber, gameObject.GetComponent<StoneScript>());
		//objenin eski pointini serbest braktım
		gameManager.clearPointStone(currPointNumber);
		//şuanki noktasını güncelle
		currPointNumber = pointNumber;
		//sırayı degiştir
		gameManager.changeTurn();
	}

	public void reset(){
		//obje kendini resetleyecek
		Vector3 pos = spawnPosition;
		pos.z = -5;
		gameObject.transform.position = pos;

		currPointNumber = 0;
	}

	private int getPointNumber(int x, int y){
		Debug.Log ("x:" + x + "-y:" + y);

		if (x == 1) {
			if (y == 1)
				return 1;
			else if (y == 2)
				return 4;
			else if (y == 3)
				return 7; 
		}
		else if (x == 2) {
			if (y == 1)
				return 2;
			else if (y == 2)
				return 5;
			else if (y == 3)
				return 8; 
		}
		else if (x == 3) {
			if (y == 1)
				return 3;
			else if (y == 2)
				return 6;
			else if (y == 3)
				return 9; 
		}

		return 1;
	}
}
