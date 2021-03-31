using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Combo1Count : MonoBehaviour {

	public static int combo1Count = 0;
	Text count;
	
	void Start()
	{
		count = GetComponent<Text>();
	}
	
	private void Update()
	{
		count.text = combo1Count.ToString();
	}
	
	public void AddCount(int range)
	{
		combo1Count += range;
	}
}
