﻿using UnityEngine;
using System.Collections;

public class Pos_Equal_Pos_REAL : MonoBehaviour {
	public Transform target;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = target.position;

	}
}
