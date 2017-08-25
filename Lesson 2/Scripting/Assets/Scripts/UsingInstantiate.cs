using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingInstantiate : MonoBehaviour {

    public GameObject spherePrefab;
    public Transform spawnPoint;

    private void Start()
    {
        //Invoke("Spawn", 3);
        Debug.Log(System.DateTime.Now.Second);
        InvokeRepeating("Spawn", 10, 3);
    }

    void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            //Instantiate(spherePrefab, new Vector3(0, 20, 0), Quaternion.identity);
            //Spawn();
            Instantiate(spherePrefab, Input.mousePosition, Quaternion.identity);
        }
	}

    private void Spawn()
    {
        Debug.Log(System.DateTime.Now.Second);
        Instantiate(spherePrefab, spawnPoint.position, Quaternion.identity);
    }
}
