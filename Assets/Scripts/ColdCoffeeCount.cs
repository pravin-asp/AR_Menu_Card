using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColdCoffeeCount : MonoBehaviour 
{

	public static int coldcoffeeCount = 0;
	Text count;
	
	void Start()
	{
		count = GetComponent<Text>();
	}
	
	private void Update()
	{
		count.text = coldcoffeeCount.ToString();
	}
	
	public void AddCount(int range)
	{
		coldcoffeeCount += range;
	}
}
