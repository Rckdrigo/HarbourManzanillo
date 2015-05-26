using UnityEngine;
using System.Collections;

public class ArcBallCamera : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		transform.LookAt(Vector3.zero);
		if(Input.GetMouseButton(0))
			transform.RotateAround(Vector3.zero,
                                new Vector3(Input.GetAxis("Mouse Y"),-Input.GetAxis("Mouse X"),0).normalized,
                                30 * Time.deltaTime);
	}


	void OnPinch( PinchGesture gesture ) 
	{
		// current gesture phase (Started/Updated/Ended)
		ContinuousGesturePhase phase = gesture.Phase;
		
		// Current gap distance between the two fingers
		float gap = gesture.Gap;
		
		// Gap difference since last frame
		float delta = gesture.Delta;
	}
}
