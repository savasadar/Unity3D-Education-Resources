﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoop : MonoBehaviour {
    
	void Start () {
        for (int i = 0; i < 10; i++)
        {
            Debug.Log("create enemy number:" + i);
        }
	}
}
