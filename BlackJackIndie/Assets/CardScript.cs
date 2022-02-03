using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardScript : MonoBehaviour
{

    public int value = 0;
    // Value of card,  2 of clubs = 2 etc for the rest of the cards
    public int getValueOfCard()
    {
        return value;
    }

    public void setValue(int newValue)
    {
        value = newValue;
    }
}
