﻿using UnityEngine;
using System.Collections;

public class Destroy_Bullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Destroy(this.gameObject,5);
	}
}
