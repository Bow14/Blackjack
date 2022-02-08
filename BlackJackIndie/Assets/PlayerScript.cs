using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {
	// https://www.youtube.com/watch?v=Nf0kUpdWeJs
	//Script is for player and dealer, This works with all the players and dealers cards
	//Just this entire series is a tutorial to get back into scripting and being able to
	//Think on my own and experiment with games for future references

	//Get other scripts
	public CardScript cardScript;
	public Deck deckScript;
	
	// Total value of player/dealers hand
	public int handValue = 0;
	//Betting money
	private int money = 100;

	// Array of card objects on table
	public GameObject[] hand;
	//index of next card to be turned over
	public int cardIndex = 0;
	public int aceCount = 0;
	//Tracking aces for 1 to 11 conversions
	private List<CardScript> aceList = new List<CardScript>();
	// Use this for initialization
	void Start () {
		
	}
	
	//Add a hand to the player and dealers hand

	public int getCard()
	{
		//Grab a card and assigns sprite value to said card
		int cardValue = deckScript.dealCard((hand[cardIndex].GetComponent<CardScript>()));
		//Show card on game screen with rendering
		hand[cardIndex].GetComponent<Renderer>().enabled = true;
		//add card value to the running total of the hand
		handValue += cardValue;

		if (cardValue == 1)
		{
			aceList.Add(hand[cardIndex].GetComponent<CardScript>());
		}

		//aceCheck();
		cardIndex++;
		return handValue;
	}
}
