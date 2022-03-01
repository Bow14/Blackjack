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
	public Text standBtmText;
	

	private int standClicks = 0;
	
	
	// access the players hand as well as the dealer
	public PlayerScript PlayerScript;
	public PlayerScript dealerScript;
	
	//public text to access and update
	public Text scoreText;
	public Text dealerScoreText;
	public Text betsText;
	public Text cashText;
	// public Text mainText
	
	// Card hidden 2nd card
	public GameObject hideCard;
	//how much is bet
	public int pot = 0;

	// Use this for initialization
	public void Start()
	{
		dealBtn.onClick.AddListener(() => dealClicked());
		hitBtn.onClick.AddListener(() => hitClicked());
		standBtm.onClick.AddListener(() => standClicked());
	}

	void dealClicked()
	{
		dealerScoreText.gameObject.SetActive(false); //hides the dealers hand at the start
		GameObject.Find("Deck").GetComponent<Deck>().cardShuffle();
		PlayerScript.StartHand();
		dealerScript.StartHand();
		//The function that allows the score being updated
		scoreText.text = "Hand: " + PlayerScript.handValue.ToString();
		dealerScoreText.text = "Hand: " + dealerScript.handValue.ToString();
		// Adjust buttons dealBtm visibility
		dealBtn.gameObject.SetActive(false);
		hitBtn.gameObject.SetActive(true);
		standBtm.gameObject.SetActive(true);
		standBtmText.text = "Stand";
		// set standard pot size
		pot = 40;
		betsText.text = pot.ToString();
		//PlayerScript.AdjustMoney(-20);
		//cashText.text = PlayerScript.GetMoney().ToString();
	}
	void hitClicked()
	{
		// Check that there is still room on the table
		if (PlayerScript.getCard() <= 10)
		{
			PlayerScript.getCard();
		}
	}
	void standClicked()
	{
		standClicks++;
		if (standClicks > 1) Debug.Log("End function");
		hitDealer();
		standBtmText.text = "Call";
		{
			
		}
	}

	private void hitDealer()
	{
		while (dealerScript.handValue < 16 && dealerScript.cardIndex < 10)
		{
			dealerScript.getCard();
			//dealerscore
		}
	}
}
