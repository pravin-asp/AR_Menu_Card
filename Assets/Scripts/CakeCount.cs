using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CakeCount : MonoBehaviour {

	public static int cakeCount = 0;
	Text count;
	
	void Start()
	{
		count = GetComponent<Text>();
	}
	
	private void Update()
	{
		count.text = cakeCount.ToString();
	}
	
	public void AddCount(int range)
	{
		cakeCount += range;
	}
}
