using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManger : MonoBehaviour
{
	// https://www.youtube.com/watch?v=vVNIoARxH6M&t=1019s

	public Button dealBtn;
	public Button hitBtn;
	public Button standBtm;
	public Button betBtn;
	
	// access the players hand as well as the dealer
	public PlayerScript PlayerScript;
	public PlayerScript dealerScript;

	// Use this for initialization
	public void Start()
	{
		dealBtn.onClick.AddListener(() => dealClicked());
		hitBtn.onClick.AddListener(() => hitClicked());
		standBtm.onClick.AddListener(() => standClicked());
	}

	void dealClicked()
	{
		GameObject.Find("Deck").GetComponent<Deck>().cardShuffle();
		PlayerScript.StartHand();
		dealerScript.StartHand();
	}
	void hitClicked()
	{
		PlayerScript.StartHand();
	}
	void standClicked()
	{
		PlayerScript.StartHand();
	}
}
