using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Combo2Count : MonoBehaviour {

	public static int combo2Count = 0;
	Text count;
	
	void Start()
	{
		count = GetComponent<Text>();
	}
	
	private void Update()
	{
		count.text = combo2Count.ToString();
	}
	
	public void AddCount(int range)
	{
		combo2Count += range;
	}
}
