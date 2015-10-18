using UnityEngine;
using System.Collections;

public class Player2Movement : MonoBehaviour {
	// Use this for initialization
	private Rigidbody2D rb;
	private GameObject bunny;
	private BunnyBehavior bunnyScript;
	private PlayerInfo playerInfo;

	void Start () {
		rb = this.GetComponent<Rigidbody2D> ();
		playerInfo = GetComponent<PlayerInfo>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("left"))
		{
			rb.AddForce(new Vector2(-2.0f, 0));
			transform.localScale = new Vector3(1, transform.localScale.y, transform.localScale.z);
			
		}
		if(Input.GetKey("right"))
		{
			rb.AddForce(new Vector2(2.0f, 0));
			transform.localScale = new Vector3(-1, transform.localScale.y, transform.localScale.z);
		}
		//this is the down button. it does nothing.
		if(Input.GetKey("down"))
		{
		}
		if(Input.GetKey("up") && playerInfo.balloonAmount>0)
		{
			rb.AddForce(new Vector2(0, 4.0f));
			//transform.position += new Vector3(0, 1f, 0);
		}
		if(Input.GetKeyDown(KeyCode.RightControl))
		{
			bunny = Instantiate(Resources.Load("Prefabs/bunny") as GameObject);
			bunny.transform.position = transform.position + new Vector3(0, 1f, 0);
			bunny.GetComponent<Rigidbody2D>().AddForce(new Vector2(-100*transform.localScale.x, 0));
			bunny.transform.localScale = new Vector2(transform.localScale.x/2 * -1, bunny.transform.localScale.y);
			bunnyScript = bunny.GetComponent<BunnyBehavior>();
			bunnyScript.heldBy = this.gameObject;
		}
	}
}
