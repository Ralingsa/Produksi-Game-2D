using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine .SceneManagement ;

public class batasakhir : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter(Collider collision) 
	{ 
		Destroy(collision.gameObject); 
		//SceneManager.LoadScene("GameOver"); // Baris Ini akan digunakan pada submodul GameOver 

	}
}
