using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Combo2Tot : MonoBehaviour {

	public static int combo2Tot = 0;
	Text amount;
	
	void Start()
	{
		amount = GetComponent<Text>();
	}
	
	private void Update()
	{
		amount.text = combo2Tot.ToString();
	}
	
	public void AddCount(int rupees)
	{
		combo2Tot += rupees;
	}
}
