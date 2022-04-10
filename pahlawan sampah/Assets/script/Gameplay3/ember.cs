using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class ember: MonoBehaviour {

	public string nameTag; 
	public AudioClip audioBenar;  
	private AudioSource MediaPlayerBenar; 
	public Text textScore; 
	public GameObject ember1; 
	public GameObject ember2;
	public GameObject ember3;
	public GameObject ember4;
	public GameObject tutup;

	// Use this for initialization 
	void Start() 
	{ 
		MediaPlayerBenar = gameObject.AddComponent<AudioSource>();
		MediaPlayerBenar.clip =audioBenar;  
		 
		ember1.SetActive (true);
		ember2.SetActive (false);
		ember3.SetActive (false);
		ember4.SetActive (false);
		tutup.SetActive (false);
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
		if (Data.score >=0)
		{
			ember1.SetActive (true);
			ember2.SetActive (false);
			ember3.SetActive (false);
			ember4.SetActive (false);
			tutup.SetActive (false);
		}
		if (Data.score >=5)
		{
			ember1.SetActive (false);
			ember2.SetActive (true);
			ember3.SetActive (false);
			ember4.SetActive (false);
			tutup.SetActive (false);
		}
		if (Data.score >=9)
		{
			ember1.SetActive (false);
			ember2.SetActive (false);
			ember3.SetActive (true);
			ember4.SetActive (false);
			tutup.SetActive (false);
		}
		if (Data.score >=15)
		{
			ember1.SetActive (false);
			ember2.SetActive (false);
			ember3.SetActive (false);
			ember4.SetActive (true);
			tutup.SetActive (false);
		}
		if (Data.score >=20)
		{
			ember1.SetActive (false);
			ember2.SetActive (false);
			ember3.SetActive (false);
			ember4.SetActive (false);
			tutup.SetActive (true);
		}
	}

}
