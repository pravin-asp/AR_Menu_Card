using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GrillChickenCount : MonoBehaviour {

	public static int grillchickenCount = 0;
	Text count;
	
	void Start()
	{
		count = GetComponent<Text>();
	}
	
	private void Update()
	{
		count.text = grillchickenCount.ToString();
	}
	
	public void AddCount(int range)
	{
		grillchickenCount += range;
	}
}
