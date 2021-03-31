using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DonutTot : MonoBehaviour {

	public static int donutTot = 0;
	Text amount;
	
	void Start()
	{
		amount = GetComponent<Text>();
	}
	
	private void Update()
	{
		amount.text = donutTot.ToString();
	}
	
	public void AddCount(int rupees)
	{
		donutTot += rupees;
	}
}
