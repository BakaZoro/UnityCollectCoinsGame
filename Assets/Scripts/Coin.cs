using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

	void OnCollisionEnter(Collision collision)
	{
		//Debug.Log (collision.gameObject.name);
		if(collision.gameObject.name == "Player")
		{
			DestroyObject (gameObject);
			MainClass.myscore++;
			MainClass.mainclassref.scoreUpdate ();
		}
	}
}
