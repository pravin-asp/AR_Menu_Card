using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalAmount : MonoBehaviour {

	public static int totalAmount = 0;
	Text amount;
	
	void Start()
	{
		amount = GetComponent<Text>();
	}
	
	private void Update()
	{
		amount.text = totalAmount.ToString();
	}
	
	public void AddCount(int rupees)
	{
		totalAmount += rupees;
	}
}
