﻿using UnityEngine;

public class cameraa : MonoBehaviour
{
	public Transform player;
	
	public Transform Bg3;
	

	 // Use this for initialization
	 void Start()
	 {
		
	 }

	 // Update is called once per frame
	 void Update()
	 {
		 if (player.position.x != transform.position.x && player.position.x > 0 && player.position.x < 100f)
			 {
			 transform.position = Vector3.Lerp(transform.position, new Vector3(player.position.x, transform.position.y, transform.position.z), 0.1f);
			 }

		 Bg3.transform.position = new Vector2(transform.position.x * 0.6f, Bg3.transform.position.y);
	}
}