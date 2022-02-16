using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{

    // https://www.youtube.com/watch?v=vVNIoARxH6M&t=460s this is this guys script for the deck
	public Sprite[] cardSprites;

	private int[] cardValues = new int[53];
	private int currentIndex = 0;

	// Use this for initialization
	void Start () {
		getCardValues();
		
	}
	
	// Update is called once per frame
	void getCardValues ()
	{
		int num = 0;
		//assigns values to cards as well as it being a for loop 
		//Just trying to get back in the flow of learning c# because of all the python ive been doing
		
		for (int i = 0; i < cardSprites.Length; i++)
		{
			num = i;
			// counts up to the amount of cards, 52
			num %= 13;
			// Divides x/13 then the remainder is used as the value if it is not over 10
			if (num > 10 || num == 0)
			{
				num = 10;
				
			}

			cardValues[i] = num++;
		}

		currentIndex = 1;
	}

	public void cardShuffle()
	{
		for (int i = cardSprites.Length - 1; i > 0; --i)
		{
			int j = Mathf.FloorToInt(Random.Range(0.0f, 1.0f) * cardSprites.Length - 1) + 1; 
			//This line above gives a random number from the array
			Sprite face = cardSprites[i];
			cardSprites[i] = cardSprites[j];
			// J is the random number result
			cardSprites[j] = face;

			int value = cardValues[i];
			cardValues[i] = cardValues[j];
			cardValues[j] = value;
		}
	}

	public int dealCard(CardScript cardScript)
	{
		cardScript.SetSprite(cardSprites[currentIndex]);
		cardScript.setValue(cardValues[currentIndex++]);
		return cardScript.getValueOfCard();
	}

	public Sprite getCardBack()
	{
		return cardSprites[0];
	}
}
