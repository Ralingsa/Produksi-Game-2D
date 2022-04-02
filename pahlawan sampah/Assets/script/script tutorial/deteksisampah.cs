using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class deteksisampah : MonoBehaviour {

	public string nameTag; 
	public AudioClip audioBenar; 
	private AudioSource MediaPlayerBenar; 
	public Text textScore; 
	// Use this for initialization 
	void Start() 
	{ 
		MediaPlayerBenar = gameObject.AddComponent<AudioSource>();
		MediaPlayerBenar.clip =audioBenar;  


	} 
	void OnTriggerEnter2D(Collider2D collision) 
	{ 
		if (collision.tag.Equals (nameTag)) { 
			Data.score += 1; 
			textScore.text = Data.score.ToString(); 
			DestroyObject(collision.gameObject); 
			MediaPlayerBenar.Play (); 
		}
		}
	}

