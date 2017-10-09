using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Silah : MonoBehaviour {

	public float vurusSuresi = 0.5f;
	public float vurusGucu = 10f;

	public Dusman suankiDusman;
	DateTime sonAtesZamani = DateTime.Now;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (sonAtesZamani.AddSeconds(vurusSuresi) > DateTime.Now) {
			//zamanı gelmemiş ateş etme
			return;
		}

		//ateş et
		if (suankiDusman != null) {
			suankiDusman.Vur (vurusGucu);
			sonAtesZamani = DateTime.Now;
		}
	}

	void OnTriggerStay2D(Collider2D collider){
		Dusman dusman = collider.gameObject.GetComponent<Dusman> ();
		if (suankiDusman == null && dusman != null) {
			suankiDusman = dusman;
		}
	}

	void OnTriggerExit2D(Collider2D collider){
		suankiDusman = null;
	}
}
