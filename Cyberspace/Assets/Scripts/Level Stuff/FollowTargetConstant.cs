﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTargetConstant : MonoBehaviour {

	public float speed = 5f; // The follow speed of the object
	public Rigidbody target; // The target to follow

	[HideInInspector] public Vector3 nextPos;
	private Rigidbody rb; // This object's rigidbody

	void Awake () {
		rb = GetComponent<Rigidbody> (); // Getting the reference
	}

	void FixedUpdate () {
		rb.MovePosition (Vector3.MoveTowards (rb.position, target.position, speed * Time.deltaTime)); // Follows the target
	}
}
