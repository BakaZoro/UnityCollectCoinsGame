using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainClass : MonoBehaviour 
{

	public static MainClass mainclassref;

	public GameObject coinPrefab;
	public Text scoreText;


	public static int myscore;

	void Start()
	{
		mainclassref = this;
		InvokeRepeating ("spawnFun",5,3);
	}

	public void scoreUpdate()
	{
		scoreText.text = "Score :"+myscore;
	}

	void spawnFun()
	{
		Vector3 randPos = new Vector3 (Random.Range(-3,3),1,Random.Range(-3,3));
		Instantiate (coinPrefab,randPos,Quaternion.identity);
	}
}
