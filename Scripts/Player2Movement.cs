using UnityEngine;
using System.Collections;

public class Player2Movement : MonoBehaviour {
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("left"))
		{
			transform.position += new Vector3(-1f, 0f, 0);
		}
		else if(Input.GetKeyDown("right"))
		{
			transform.position += new Vector3(1f, 0f, 0);
		}
		else if(Input.GetKeyDown("down"))
		{
			transform.position += new Vector3(0, -1f, 0);
		}
		else if(Input.GetKeyDown("up"))
		{
			transform.position += new Vector3(0, 1f, 0);
		}
	}
}