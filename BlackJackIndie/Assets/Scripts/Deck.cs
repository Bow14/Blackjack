using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{

    // https://www.youtube.com/watch?v=vVNIoARxH6M&t=460s this is this guys script for the deck
	public Sprite[] cardSprites;

	private int[] cardValues = new int[53];

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void getCardValues ()
	{
		int num = 0;
		for (int i = 0; i < cardSprites.Length; i++)
		{
			num = i;
			num %= 13;
			if (num > 10 || num == 0)
			{
				num = 10;
				
			}

			cardValues[i] = num++;
		}
	}
}
