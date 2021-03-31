using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColdCoffeeTot : MonoBehaviour {

	public static int coldcoffeeTot = 0;
	Text amount;
	
	void Start()
	{
		amount = GetComponent<Text>();
	}
	
	private void Update()
	{
		amount.text = coldcoffeeTot.ToString();
	}
	
	public void AddCount(int rupees)
	{
		coldcoffeeTot += rupees;
	}
}
