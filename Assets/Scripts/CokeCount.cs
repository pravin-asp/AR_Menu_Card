using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CokeCount : MonoBehaviour 
{
	public static int cokeCount = 0;
	Text count;
	
	void Start()
	{
		count = GetComponent<Text>();
	}
	
	private void Update()
	{
		count.text = cokeCount.ToString();
	}
	
	public void AddCount(int range)
	{
		cokeCount += range;
	}
}