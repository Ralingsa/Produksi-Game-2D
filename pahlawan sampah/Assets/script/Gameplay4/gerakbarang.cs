﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class gerakbarang : MonoBehaviour {
	float speed = 0f;
	Rigidbody2D rigid;
	public string nameTag;


	// Use this for initialization
	void Start () {
		rigid = GetComponent <Rigidbody2D > ();
		
		
	}
	
	// Update is called once per frame
	void Update () {
			float move = (speed * Time.deltaTime * -1f) + transform.position.x;
			transform.position = new Vector3 (move, transform.position.y);
		}
		private Vector3 screenPoint; 
		private Vector3 offset; 
		private float firstY; 
		void OnMouseDown() 
		{ 
			firstY = transform.position.y; 
			screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position); 
			offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint .z)); 
		} 
		void OnMouseDrag() 
		{ 
			Vector3 curScreenPoint = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
			Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
			transform.position = curPosition; 
		} 
		private void OnMouseUp() 
		{ 
			transform.position = new Vector3(transform.position.x,firstY, transform.position.z); 
		}

		}
