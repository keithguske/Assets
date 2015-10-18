using UnityEngine;
using System.Collections;

public class Player1Movement : MonoBehaviour {
	// Use this for initialization
	private Rigidbody2D rb;
<<<<<<< HEAD

	public float cooldown = .55f;

	private float timeStamp = 0;

	//Sprivate Animator

=======
	private GameObject bunny;
	private BunnyBehavior bunnyScript;
	private PlayerInfo playerInfo;
>>>>>>> 0ee87d967b299d04ddc2c5a2c35a41e70a3a1a39

	void Start () {
		rb = this.GetComponent<Rigidbody2D> ();
		playerInfo = this.gameObject.GetComponent<PlayerInfo>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("a"))
		{
<<<<<<< HEAD

			rb.AddForce(new Vector2(-1.0f, 0));
			print("yes");

		}
		if(Input.GetKey("d"))
=======
			rb.AddForce(new Vector2(-2.0f, 0));
			transform.localScale = new Vector3(1, transform.localScale.y, transform.localScale.z);

		}
		if(Input.GetKey("d"))
		{
			rb.AddForce(new Vector2(2.0f, 0));
			transform.localScale = new Vector3(-1, transform.localScale.y, transform.localScale.z);
		}
		//this is the down button, it does nothing
		if(Input.GetKey("s"))
>>>>>>> 0ee87d967b299d04ddc2c5a2c35a41e70a3a1a39
		{
		}
<<<<<<< HEAD
		if(Input.GetKey("s"))
=======
		if(Input.GetKey("w") && playerInfo.balloonAmount>0)
>>>>>>> 0ee87d967b299d04ddc2c5a2c35a41e70a3a1a39
		{
			rb.AddForce(new Vector2(0, 4.0f));
		}
<<<<<<< HEAD
		if(Time.time >= timeStamp && Input.GetKey("w"))
		{
			rb.AddForce(new Vector2(0, 30f));
			//transform.position += new Vector3(0, 1f, 0);

			timeStamp = Time.time + cooldown;
			Debug.Log("here");
=======
		if(Input.GetKeyDown("f"))
		{
			bunny = Instantiate(Resources.Load("Prefabs/bunny") as GameObject);
			bunny.transform.position = transform.position + new Vector3(0, 1f, 0);
			bunny.GetComponent<Rigidbody2D>().AddForce(new Vector2(-100*transform.localScale.x, 0));
			bunny.transform.localScale = new Vector2(transform.localScale.x/2 * -1, bunny.transform.localScale.y);
			bunnyScript = bunny.GetComponent<BunnyBehavior>();
			bunnyScript.heldBy = this.gameObject;

>>>>>>> 0ee87d967b299d04ddc2c5a2c35a41e70a3a1a39
		}
	}
}
