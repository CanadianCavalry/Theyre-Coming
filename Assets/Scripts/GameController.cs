﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	public Enemy enemy;
	private GameObject player;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");

		/*
		UnityEngine.Tilemaps.TilemapCollider2D terrain = GameObject.FindGameObjectWithTag ("Terrain").GetComponent<UnityEngine.Tilemaps.TilemapCollider2D> ();
		Debug.Log (terrain);

		terrain.enabled = false;
		terrain.enabled = true;
		*/
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("t")) {
			spawnEnemy (6.0f);
		}
	}

	void spawnEnemy(float xPos) {
		Enemy newEnemy = Instantiate (enemy, new Vector3(xPos, enemy.transform.position.y, 0), Quaternion.identity);
	}
}
