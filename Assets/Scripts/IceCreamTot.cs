using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IceCreamTot : MonoBehaviour {

	public static int icecreamTot = 0;
	Text amount;
	
	void Start()
	{
		amount = GetComponent<Text>();
	}
	
	private void Update()
	{
		amount.text = icecreamTot.ToString();
	}
	
	public void AddCount(int rupees)
	{
		icecreamTot += rupees;
	}
}
