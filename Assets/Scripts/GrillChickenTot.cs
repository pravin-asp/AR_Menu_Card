using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GrillChickenTot : MonoBehaviour {

	public static int grillchickenTot = 0;
	Text amount;
	
	void Start()
	{
		amount = GetComponent<Text>();
	}
	
	private void Update()
	{
		amount.text = grillchickenTot.ToString();
	}
	
	public void AddCount(int rupees)
	{
		grillchickenTot += rupees;
	}
}
