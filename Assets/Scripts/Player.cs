using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float speed;
	Vector3 newPos;
	Vector3 initalPos;
	float xValue;
	float zValue;

	void Start()
	{
		initalPos = gameObject.transform.position;
	}
	void Update()
	{
		if(Input.GetKey(KeyCode.RightArrow))
			GetComponent<Rigidbody> ().AddForce (Vector3.forward * speed);
	}
	void Update_ () 
	{
		if(Input.GetKey(KeyCode.RightArrow))
		{
			xValue += speed;
			newPos = new Vector3 (xValue,0,zValue) + initalPos;
			gameObject.transform.position = newPos;
		}
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			xValue -= speed;
			newPos = new Vector3 (xValue,0,zValue) + initalPos;
			gameObject.transform.position = newPos;
		}

		if(Input.GetKey(KeyCode.UpArrow))
		{
			zValue += speed;
			newPos = new Vector3 (xValue,0,zValue) + initalPos;
			gameObject.transform.position = newPos;
		}
		if(Input.GetKey(KeyCode.DownArrow))
		{
			zValue -= speed;
			newPos = new Vector3 (xValue,0,zValue) + initalPos;
			gameObject.transform.position = newPos;
		}

	}
}
