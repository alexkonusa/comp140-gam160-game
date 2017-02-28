/* This was my first time using the WheelColliders in Unity to make a physics based vehicle,
 * I have used their lesson to adapt and create my own vehicle controller.
 * link to the article: https://docs.unity3d.com/Manual/WheelColliderTutorial.html*/

using UnityEngine;
using System.Collections;

public class _CarController : MonoBehaviour 
{

	public WheelCollider leftWheel;
	public WheelCollider rightWheel;
	public WheelCollider rearLeftWheel;
	public WheelCollider rearRightWheel;

	public float wheelSteeringAngle = 30.0f;
	public float motorTorque = 400.0f;

	void Start()
	{



	}
		
	void FixedUpdate () 
	{

		CarInput ();

	}

	void CarInput ()
	{

		float turnInput = 0;
		turnInput += (Input.GetKey (KeyCode.RightArrow)) ? 1 : 0;
		turnInput += (Input.GetKey (KeyCode.LeftArrow)) ? -1 : 0;

		leftWheel.steerAngle = wheelSteeringAngle * turnInput;
		rightWheel.steerAngle = wheelSteeringAngle * turnInput;

		float motorInput = 0;
		motorInput += (Input.GetKey (KeyCode.UpArrow)) ? 1 : 0;
		motorInput += (Input.GetKey (KeyCode.DownArrow)) ? -1 : 0;

		rearLeftWheel.motorTorque = motorTorque * motorInput;
		rearRightWheel.motorTorque = motorTorque * motorInput;


		VisualWheels (leftWheel);
		VisualWheels (rightWheel);
	}

	void VisualWheels (WheelCollider collider)
	{

		Transform visualWheel = collider.transform.GetChild (0);
		Vector3 position = collider.transform.localPosition;
		Quaternion rotation = collider.transform.localRotation;
		collider.GetWorldPose (out position, out rotation);

		visualWheel.transform.position = position;
		visualWheel.transform.rotation = rotation;

	}
}
