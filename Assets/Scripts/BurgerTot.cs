using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BurgerTot : MonoBehaviour {

	public static int burgerTot = 0;
	Text amount;
	
	void Start()
	{
		amount = GetComponent<Text>();
	}
	
	private void Update()
	{
		amount.text = burgerTot.ToString();
	}
	
	public void AddCount(int rupees)
	{
		burgerTot += rupees;
	}
}
