﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteCube : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	void OnCollisionEnter (Collision col)
	{
//		print (col.gameObject.name);
		ObjectPoolMgr.Instance.RecycleObject (col.gameObject);
	}
}