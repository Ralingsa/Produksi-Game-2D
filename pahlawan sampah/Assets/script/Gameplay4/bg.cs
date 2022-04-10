using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine .UI; 

public class bg : MonoBehaviour {
	public string nameTag;
	Rigidbody2D rigid;
	public Text textScore; 
	public GameObject HasilJadihiasan;
	public GameObject HasilJadipot;
	public GameObject HasilJaditisu;
	public GameObject pot;
	public GameObject hiasan;
	public GameObject tisu;
	int count ; 


	// Use this for initialization
	void Start () {
		HasilJadihiasan.SetActive (false);
		HasilJadipot.SetActive (false);
		HasilJaditisu.SetActive (false);



		
	}
	
	// Update is called once per frame
	void Update () {
		if (Data.pot == pot && count == 2) 
		{
			potjadi ();

		}
		if (Data.hiasan  == hiasan  && count == 3) 
		{
			hiasanJadi  ();

		}
		if (Data.tisu   == tisu   && count == 4) 
		{
			tisuJadi  ();

		}
		rigid = GetComponent <Rigidbody2D > ();
	}
	void OnTriggerEnter2D (Collider2D collision)
	{ 

		if (collision.tag.Equals (nameTag)) {
			DestroyObject (collision.gameObject);
			count++; 
		}
			
	}

	public void HasilJadipotClicked ()
	{

		pot.SetActive (true);
	}
	public void HasilJadihiasanClicked ()
	{
		hiasan.SetActive (true);

	}
	public void hasilJaditisuClicked ()
	{
		tisu.SetActive(true);
	}
		
	void potjadi ()
	{
		count = 0;
		HasilJadipot.SetActive (true);
	}
	void hiasanJadi ()
	{
		count = 0; 
		HasilJadihiasan.SetActive (true);
	}
		void tisuJadi ()
		{
			count = 0; 
			HasilJaditisu.SetActive (true);

}
}
