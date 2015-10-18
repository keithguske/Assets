using UnityEngine;
using System.Collections;

public class PlayerInfo : MonoBehaviour {
	public int balloonAmount;
	public bool hasBunny;
	private Animator anim;

	int balloonAMTHash = Animator.StringToHash("balloonAMT");

	// Use this for initialization
	void Awake () {
		balloonAmount = 3;
		hasBunny = false;
		anim = this.gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		anim.SetInteger(balloonAMTHash, balloonAmount);
	}
}
