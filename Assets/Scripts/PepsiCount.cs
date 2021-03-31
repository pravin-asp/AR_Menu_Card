using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PepsiCount : MonoBehaviour {

	public static int pepsiCount = 0;
	Text count;
	
	void Start()
	{
		count = GetComponent<Text>();
	}
	
	private void Update()
	{
		count.text = pepsiCount.ToString();
	}
	
	public void AddCount(int range)
	{
		pepsiCount += range;
	}
}
