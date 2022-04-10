using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement ;

public class panel: MonoBehaviour {
	public GameObject awalmenu;
	public GameObject milihmenupot;
	public GameObject milihmenuhiasan;
	public GameObject milihmenutisu;
	public GameObject kembali;
	public GameObject hasilpot;
	public GameObject hasilhiasan;
	public GameObject hasiltisu;
	public GameObject HasilJadipot;
	public GameObject HasilJadihiasan;
	public GameObject HasilJaditisu;




	// Use this for initialization
	void Start () {
		awalmenu.SetActive (true);
		milihmenupot.SetActive (false);
		milihmenuhiasan.SetActive (false);
		milihmenutisu.SetActive (false);
		kembali.SetActive (true);
		HasilJadipot.SetActive (false);
		HasilJadihiasan.SetActive (false);
		HasilJaditisu.SetActive (false);
		hasilpot.SetActive (false);
		hasilhiasan.SetActive (false);
		hasiltisu.SetActive (false);
	

	}

	// Update is called once per frame
	void Update () {
	}
	public void HasilJadipotClicked()
	{
		awalmenu.SetActive (false);
		milihmenupot.SetActive (false);
		milihmenuhiasan.SetActive (false);
		milihmenutisu.SetActive (false);
		HasilJadipot.SetActive (true);
		HasilJadihiasan.SetActive (false);
		HasilJaditisu.SetActive (false);

	}
	public void HasilJadihiasanClicked()
	{
		awalmenu.SetActive (false);
		milihmenupot.SetActive (false);
		milihmenuhiasan.SetActive (false);
		milihmenutisu.SetActive (false);
		HasilJadipot.SetActive (false);
		HasilJadihiasan.SetActive (true);
		HasilJaditisu.SetActive (false);

	}
	public void HasilJaditisuClicked()
	{
		awalmenu.SetActive (false);
		milihmenupot.SetActive (false);
		milihmenuhiasan.SetActive (false);
		milihmenutisu.SetActive (false);
		HasilJadipot.SetActive (false);
		HasilJadihiasan.SetActive (false);
		HasilJaditisu.SetActive (true);

	}

		
	public void kembaliClicked()
	{
		awalmenu.SetActive (true);
		milihmenupot.SetActive (false);
		milihmenuhiasan.SetActive (false);
		milihmenutisu.SetActive (false);
		Data.pot = false;


	}

	public void potClicked()
	{
		awalmenu.SetActive (false);
		milihmenupot.SetActive (true);
		milihmenuhiasan.SetActive (false);
		milihmenutisu.SetActive (false);
		kembali.SetActive (true);
		Data.pot = true;
	}
	public void tisuClicked()
	{

		awalmenu.SetActive (false);
		milihmenupot.SetActive (false);
		milihmenuhiasan.SetActive (false);
		milihmenutisu.SetActive (true);
		kembali.SetActive (true);
		Data.tisu = true;
	}
	public void hiasanClicked
	()
	{
		awalmenu.SetActive (false);
		milihmenupot.SetActive (false);
		milihmenuhiasan.SetActive (true);
		milihmenutisu.SetActive (false);
		kembali.SetActive (true);
		Data.hiasan = true; 
	}
	public void Quit_Clicked()
	{
		Application.Quit ();

	}






	}
