using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dusman : MonoBehaviour {

	public Image canBari;
	public SpriteRenderer animation;
	public int hedefYolNoktasi = 0;
	public int maxHiz = 5;
	public float can = 100;

	public float suankiHiz = 0;
	Yol yol;

	void Start () {
		yol = GameObject.FindGameObjectWithTag ("yol").GetComponent<Yol> ();
	}
	
	// Update is called once per frame
	void Update () {
		//hedef noktanın konumunu alıyoruz
		Vector3 hedefYolNoktasiKonumu = yol.yolNoktalari [hedefYolNoktasi].transform.position;

		//yönünü hedef noktaya çevir
		transform.right = Vector3.RotateTowards(transform.right, hedefYolNoktasiKonumu - transform.position, suankiHiz*Time.deltaTime, 0.0f);
		//hedef noktaya dogru 1 adım at
		transform.position = Vector3.MoveTowards (transform.position, hedefYolNoktasiKonumu, suankiHiz*Time.deltaTime);

		//hedefe ulaştımı kontrol et
		if (transform.position == hedefYolNoktasiKonumu) {
			//hedefe ulaştı, yolun sonunda degilse hedefi degiştir
			if (yol.yolNoktalari.Length - 1 > hedefYolNoktasi)
				hedefYolNoktasi++;
			else {
				//yolun sonunda!!
			}
		}

		canBari.fillAmount = can / 100;
		if (can < 1) {
			//düşman öldü
			animation.enabled = true;
			Destroy (gameObject, .5f);
		}

		if (suankiHiz < maxHiz) {
			suankiHiz = suankiHiz + 0.1f;
		}
	}

	public void Vur(float vurusGucu){
		can = can - vurusGucu;
		if (suankiHiz > 2.1f) {
			suankiHiz = suankiHiz - 2;
		}
	}
}
