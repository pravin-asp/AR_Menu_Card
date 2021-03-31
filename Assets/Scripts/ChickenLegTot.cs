using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChickenLegTot : MonoBehaviour {

	public static int chickenlegTot = 0;
	Text amount;
	
	void Start()
	{
		amount = GetComponent<Text>();
	}
	
	private void Update()
	{
		amount.text = chickenlegTot.ToString();
	}
	
	public void AddCount(int rupees)
	{
		chickenlegTot += rupees;
	}
}
