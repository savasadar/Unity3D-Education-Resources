﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Player")
        {
            gameObject.SetActive(false);
            GameController.score++;
            Invoke("setActiveEnemy", 2);
        }

        Debug.Log(collision.gameObject.name);
    }

    private void setActiveEnemy()
    {
        gameObject.SetActive(true);
    }
    
}
