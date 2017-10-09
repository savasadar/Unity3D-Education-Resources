using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DusmanKalesi : MonoBehaviour {

	public Canvas mainCanvas;
	public Dusman dusmanPrefab;
	public float dogumZamani = 0.5f;

	DateTime sonDogumZamani = DateTime.Now;

	void Start () {
		
	}

	void Update () {
		if (sonDogumZamani < DateTime.Now.AddSeconds(-dogumZamani)) {
			Dusman dusman = (Dusman)Instantiate (dusmanPrefab, transform.position, Quaternion.identity);
			//dusman.can = dusman.can + UnityEngine.Random.Range(-10, 10);
			dusman.transform.SetParent(mainCanvas.transform);
			sonDogumZamani = DateTime.Now;
		}
	}
}
