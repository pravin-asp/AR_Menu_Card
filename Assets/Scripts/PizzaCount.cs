using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PizzaCount : MonoBehaviour 
{
	public static int pizzaCount = 0;
	Text count;
	
	void Start()
	{
		count = GetComponent<Text>();
	}
	
	private void Update()
	{
		count.text = pizzaCount.ToString();
	}
	
	public void AddCount(int range)
	{
		pizzaCount += range;
	}
}
