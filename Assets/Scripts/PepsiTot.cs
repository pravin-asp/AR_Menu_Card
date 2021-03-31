using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PepsiTot : MonoBehaviour {

	public static int pepsiTot = 0;
	Text amount;
	
	void Start()
	{
		amount = GetComponent<Text>();
	}
	
	private void Update()
	{
		amount.text = pepsiTot.ToString();
	}
	
	public void AddCount(int rupees)
	{
		pepsiTot += rupees;
	}
}
