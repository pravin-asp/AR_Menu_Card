using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadLevel : MonoBehaviour {

	public void nextLevel(string level)
	{
		Application.LoadLevel(level);
	}
	
	public void QuitGame()
	{
		Debug.Log("Quit !");
		Application.Quit();
	}
}
