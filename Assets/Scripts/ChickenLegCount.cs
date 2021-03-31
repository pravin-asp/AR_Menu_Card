using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChickenLegCount : MonoBehaviour {

	public static int chickenlegCount = 0;
	Text count;
	
	void Start()
	{
		count = GetComponent<Text>();
	}
	
	private void Update()
	{
		count.text = chickenlegCount.ToString();
	}
	
	public void AddCount(int range)
	{
		chickenlegCount += range;
	}
}
