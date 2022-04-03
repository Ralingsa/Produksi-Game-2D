using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class ember: MonoBehaviour {

	public string nameTag; 
	public AudioClip audioBenar; 
	public AudioClip audioSalah; 
	private AudioSource MediaPlayerBenar; 
	private AudioSource MediaPlayerSalah; 
	public Text textScore; 
	public GameObject Panel; 
	Text txpemenang;
	public GameObject button;
	// Use this for initialization 
	void Start() 
	{ 
		MediaPlayerBenar = gameObject.AddComponent<AudioSource>();
		MediaPlayerBenar.clip =audioBenar;  

		MediaPlayerSalah = gameObject.AddComponent<AudioSource>();
		MediaPlayerSalah.clip =audioSalah; 
		Panel.SetActive (false);

	} 
	void OnTriggerEnter2D(Collider2D collision) 
	{ 
		if (collision.tag.Equals(nameTag)) 
		{ 
			Data.score += 2; 
			textScore.text = Data.score.ToString(); 
			DestroyObject(collision.gameObject); 
			MediaPlayerBenar.Play(); 
		} 
		else 
		{
			Data.score -= 1; 
			textScore.text = Data.score.ToString(); 
			Destroy(collision.gameObject); 
			MediaPlayerSalah.Play(); 
		}
		if (Data.score >=15)
		{
			Panel.SetActive (true);
			button.SetActive (false);
			DestroyObject(gameObject);
			txpemenang = GameObject .Find ("Panel").GetComponent <Text >();
			return ;
		}
	}

}
