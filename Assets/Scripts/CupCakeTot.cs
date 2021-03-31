using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CupCakeTot : MonoBehaviour {

	public static int cupcakeTot = 0;
	Text amount;
	
	void Start()
	{
		amount = GetComponent<Text>();
	}
	
	private void Update()
	{
		amount.text = cupcakeTot.ToString();
	}
	
	public void AddCount(int rupees)
	{
		cupcakeTot += rupees;
	}
}
