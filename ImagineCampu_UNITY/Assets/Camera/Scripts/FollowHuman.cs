﻿using UnityEngine;
using System.Collections;

public class FollowHuman : MonoBehaviour {
	[SerializeField] private GameObject objetToBeFollowed;
	[SerializeField] private bool isFollowingObject=false;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (isFollowingObject) {
			if(Mathf.Abs( objetToBeFollowed.transform.position.x - transform.position.x ) > 6f) {
				transform.position = new Vector3 (objetToBeFollowed.transform.position.x,transform.position.y,-20);
			}
		}
	}

	public void activateFollow() {
		isFollowingObject = true;
	}

	public void deactivateFollow () {
		isFollowingObject = false;
	}
}
