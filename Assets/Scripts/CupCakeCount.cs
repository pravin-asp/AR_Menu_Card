using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CupCakeCount : MonoBehaviour {

	public static int cupcakeCount = 0;
	Text count;
	
	void Start()
	{
		count = GetComponent<Text>();
	}
	
	private void Update()
	{
		count.text = cupcakeCount.ToString();
	}
	
	public void AddCount(int range)
	{
		cupcakeCount += range;
	}
}
