using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CokeTot : MonoBehaviour {

	public static int cokeTot = 0;
	Text amount;
	
	void Start()
	{
		amount = GetComponent<Text>();
	}
	
	private void Update()
	{
		amount.text = cokeTot.ToString();
	}
	
	public void AddCount(int rupees)
	{
		cokeTot += rupees;
	}
}
