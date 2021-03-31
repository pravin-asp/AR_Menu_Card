using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Combo1Tot : MonoBehaviour {

	public static int combo1Tot = 0;
	Text amount;
	
	void Start()
	{
		amount = GetComponent<Text>();
	}
	
	private void Update()
	{
		amount.text = combo1Tot.ToString();
	}
	
	public void AddCount(int rupees)
	{
		combo1Tot += rupees;
	}
}
