using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseClick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	Vector3 screenPoint;
	Vector3 offset;
	float firstY, firstX;
	void OnMouseDown()
	{
		firstY = transform.position.y;
		firstX = transform.position.x;
		screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
		offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
	}
	void OnMouseDrag()
	{
		Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
		Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
		transform.position = curPosition;
	}
	private void OnMouseUp()
	{
		//transform.position = new Vector3(transform.position.x, firstY, transform.position.z);
		//transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
		transform.position = new Vector3(firstX, firstY, transform.position.z);
	}
}
