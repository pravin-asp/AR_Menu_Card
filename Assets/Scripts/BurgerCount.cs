using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BurgerCount : MonoBehaviour 
{

	public static int burgerCount = 0;
	Text count;
	
	void Start()
	{
		count = GetComponent<Text>();
	}
	
	private void Update()
	{
		count.text = burgerCount.ToString();
	}
	
	public void AddCount(int range)
	{
		burgerCount += range;
	}
}
