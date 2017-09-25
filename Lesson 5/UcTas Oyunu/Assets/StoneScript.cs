using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneScript : MonoBehaviour {

	public enum TYPE {P1, P2};

	public TYPE type = TYPE.P1;

	public Sprite p1;
	public Sprite p2;

	public GameObject[] points;

	Vector3 firstClickPosition;

	bool isMoving = false;

	void Start () {
		if(type == TYPE.P1)
			GetComponent<SpriteRenderer> ().sprite = p1;
		else
			GetComponent<SpriteRenderer> ().sprite = p2;
	}

	void Update () {
		//Drag and Drop
		if (Input.GetMouseButtonDown (0)) {
			Collider hit = checkTouch (Input.mousePosition);
			if (hit != null && hit.gameObject.Equals (gameObject)) {
				isMoving = true;	
			}
		} 
		else if (Input.GetMouseButtonUp (0)) {
			Collider hit = checkTouch (Input.mousePosition);
			if (hit != null && hit.gameObject.Equals (gameObject)) {
				isMoving = false;	
				PutToPoint (Input.mousePosition);
			}
		}

		if (isMoving) {
			Vector3 mPos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			mPos.z = -5;
			gameObject.transform.position = mPos;
		}
	}

	private Collider checkTouch(Vector3 position){
		Ray ray = Camera.main.ScreenPointToRay( Input.mousePosition );
		RaycastHit hit;
		Physics.Raycast (ray, out hit);

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

		Debug.Log ("mpos:" + mPos);
		Debug.Log ("height:" + height);
		Debug.Log ("width:" + width);

		int y = 1;
		int x = 1;

		if (mPos.y < height / 3) {
			//y 1. bölgede
			y = 1;
		}
		else if (mPos.y > height / 3 && mPos.y < height / 3 * 2) {
			//y 2. bölgede
			y = 2;
		}
		else if (mPos.y > height / 3 * 2) {
			//y 3. bölgede
			y = 3;
		}

		if (mPos.x < width / 3) {
			//y x. bölgede
			x = 1;
		}
		else if (mPos.x > width / 3 && mPos.x < width / 3 * 2) {
			//x 2. bölgede
			x = 2;
		}
		else if (mPos.x > width / 3 * 2) {
			//x 3. bölgede
			x = 3;
		}

		int point = getPointNumber (x, y);

		//set stone position
		Vector3 newPos = points[point-1].transform.position;
		newPos.z = -5;
		gameObject.transform.position = newPos;
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
