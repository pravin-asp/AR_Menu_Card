using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CakeTot : MonoBehaviour {

	public static int cakeTot = 0;
	Text amount;
	
	void Start()
	{
		amount = GetComponent<Text>();
	}
	
	private void Update()
	{
		amount.text = cakeTot.ToString();
	}
	
	public void AddCount(int rupees)
	{
		cakeTot += rupees;
	}
}
