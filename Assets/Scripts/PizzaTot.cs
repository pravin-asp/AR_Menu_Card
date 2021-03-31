using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PizzaTot : MonoBehaviour {

	public static int pizzaTot = 0;
	Text amount;
	
	void Start()
	{
		amount = GetComponent<Text>();
	}
	
	private void Update()
	{
		amount.text = pizzaTot.ToString();
	}
	
	public void AddCount(int rupees)
	{
		pizzaTot += rupees;
	}
}
