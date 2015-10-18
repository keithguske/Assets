﻿using UnityEngine;
using System.Collections;

public class Player1Movement : MonoBehaviour {
	// Use this for initialization
	private Rigidbody2D rb;

	public float cooldown = .55f;

	private float timeStamp = 0;

	//Sprivate Animator


	void Start () {
		rb = this.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("a"))
		{

			rb.AddForce(new Vector2(-1.0f, 0));
			print("yes");

		}
		if(Input.GetKey("d"))
		{
			rb.AddForce(new Vector2(1.0f, 0));
			//transform.position += new Vector3(1f, 0f, 0);
		}
		if(Input.GetKey("s"))
		{
			Debug.Log("This is the down button, it does nothing");
			//transform.position += new Vector3(0, -1f, 0);
		}
		if(Time.time >= timeStamp && Input.GetKey("w"))
		{
			rb.AddForce(new Vector2(0, 30f));
			//transform.position += new Vector3(0, 1f, 0);

			timeStamp = Time.time + cooldown;
			Debug.Log("here");
		}
	}
}
