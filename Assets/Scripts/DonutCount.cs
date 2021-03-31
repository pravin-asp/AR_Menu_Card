using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DonutCount : MonoBehaviour {

	public static int donutCount = 0;
	Text count;
	
	void Start()
	{
		count = GetComponent<Text>();
	}
	
	private void Update()
	{
		count.text = donutCount.ToString();
	}
	
	public void AddCount(int range)
	{
		donutCount += range;
	}
}
