using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muncultanah: MonoBehaviour {

	  
	public GameObject[] obyekTanah; 
	// Use this for initialization 
	void Start() { 
		int random = Random.Range(0, obyekTanah.Length);
		Instantiate(obyekTanah [random], transform.position, transform.rotation);
	}
	// Update is called once per frame 
	void Update() { 
	 
		if (Input.GetMouseButtonUp (0))
			
		{ 
			int random = Random.Range(0, obyekTanah.Length);
			Instantiate(obyekTanah[random], transform.position, transform.rotation); 
		
		}
	}
}