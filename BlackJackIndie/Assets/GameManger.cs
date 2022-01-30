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

	// Use this for initialization
	void Start ()
	{
		dealBtn.onClick.AddListener(() => dealClicked());
		//hitBtn.onClick.AddListener(() => hitClicked());
		//standBtm.onClick.AddListener(() => standClicked());
	}

	void dealClicked()
	{
			
	}
}
