using UnityEngine;
using System.Collections;

public class BunnyBehavior : MonoBehaviour {
	public GameObject player1;
	public GameObject player2;
	public GameObject heldBy;
	private PlayerInfo player1Info;
	private PlayerInfo player2Info;
	

	// Use this for initialization
	void Start () {
		player1 = GameObject.Find("Player1");
		player2 = GameObject.Find("Player2");
		player1Info = player1.GetComponent<PlayerInfo>();
		player2Info = player2.GetComponent<PlayerInfo>();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		print("2 Bunnies just collided");
	}
	void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.name == "Player1" && heldBy.name == "Player2")
		{
			player1Info.balloonAmount -= 1;
			print ("Player1 just lost a balloon");
		}
		if(collision.name == "Player2" && heldBy.name == "Player1")
		{
			player2Info.balloonAmount -= 1;
			print ("Player2 just lost a balloon");
		}
	}	
}
