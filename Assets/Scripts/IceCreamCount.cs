using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IceCreamCount : MonoBehaviour {

	public static int icecreamCount = 0;
	Text count;
	
	void Start()
	{
		count = GetComponent<Text>();
	}
	
	private void Update()
	{
		count.text = icecreamCount.ToString();
	}
	
	public void AddCount(int range)
	{
		icecreamCount += range;
	}
}
