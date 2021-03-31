using UnityEngine;

public class SwipeRotate : MonoBehaviour
{
	private Touch touch;
	
	private Vector2 touchPosition;
	
	private Quaternion rotationY;
	
	private float rotateSpeedModifier = 0.1f;
	
	void Update()
	{
		if(Input.touchCount > 0)
		{
			touch = Input.GetTouch(0);
			
			if (touch.phase == TouchPhase.Moved)
			{
				rotationY = Quaternion.Euler(
					- touch.deltaPosition.x * rotateSpeedModifier,
					- touch.deltaPosition.x * rotateSpeedModifier,
					- touch.deltaPosition.x * rotateSpeedModifier);
					
				transform.rotation = rotationY * transform.rotation;
			}
		}
	}
}