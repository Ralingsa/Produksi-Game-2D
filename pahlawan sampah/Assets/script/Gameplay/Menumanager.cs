using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement ;

public class Menumanager: MonoBehaviour {
	public GameObject Level2;
	public GameObject Kembali;




	// Use this for initialization
	void Start () {


	}

	// Update is called once per frame
	void Update () {
	}

	public void Level2Clicked()
	{
		Application.LoadLevel ("Gameplay2");
	}
	public void KembaliClicked()
	{
		Application.LoadLevel ("mainMenu");
	}
	}

