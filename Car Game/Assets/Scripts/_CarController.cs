/* This was my first time using the WheelColliders in Unity to make a physics based vehicle,
 * I have used their lesson to adapt and create my own vehicle controller.
 * link to the article: https://docs.unity3d.com/Manual/WheelColliderTutorial.html*/

using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class _CarController : MonoBehaviour 
{

    //This is where we place our wheel colliders.
	public WheelCollider leftWheel;
	public WheelCollider rightWheel;
	public WheelCollider rearLeftWheel;
	public WheelCollider rearRightWheel;

    //Our steering angle and motorTorque
	public float wheelSteeringAngle = 30.0f;
	public float motorTorque = 400.0f;

    //Portlistener variable
    PortListener portListener;

    //Rigid body for center of mass
    Rigidbody rb;

	void Start()
	{

        //Declaring our portListener script so that we can use our inputs
        portListener = GameObject.Find("GameManager").GetComponent<PortListener>();

        rb = GetComponent<Rigidbody>();

        //Changing the center of the rigidbody mass
        Vector3 CenterOfMass = new Vector3(0, 0, 0.2f);
        rb.centerOfMass += CenterOfMass;

    }

    void FixedUpdate () 
	{

		//CarInput ();

        //Running our car input in fixed update
        ArduinoCarController();


    }

    void ArduinoCarController()
    {

        float turnInput = 0;
        float motorInput = 0;

        //if the value is 0 the wheels will point straight.
        //Else if yInput is lower than -90 it will steer left and if its higher than 60 
        //it will steer right
        if (portListener.yInput <= -90)
        {

            turnInput = 1;

       }
        if (portListener.yInput >= 60)
        {

            turnInput = -1;

        }

        //Applying our values and moving the car
        leftWheel.steerAngle = wheelSteeringAngle * turnInput;
        rightWheel.steerAngle = wheelSteeringAngle * turnInput;

        //Accelerate and Reverse
        // If button one and two are 1 it will change the motor input
        // If the buttons are not pressed then the can will eventually stop and the value will be 0 
        if (portListener.buttonOne == 1)
        {

            motorInput = 1;

        }
        if (portListener.buttonTwo == 1)
        {

            motorInput = -1;

        }

        //Apply our values to the engine
        rearLeftWheel.motorTorque = motorTorque * motorInput;
        rearRightWheel.motorTorque = motorTorque * motorInput;

        //Applying our visual wheels, for te front and back
        VisualWheels(leftWheel);
        VisualWheels(rightWheel);

    }

	void CarInput ()
	{

        //If both inputs are pressed at the same time value will be 0
        //if the value is 0 the wheels will point straight.
		float turnInput = 0;
		turnInput += (Input.GetKey (KeyCode.RightArrow)) ? 1 : 0;
		turnInput += (Input.GetKey (KeyCode.LeftArrow)) ? -1 : 0;

		leftWheel.steerAngle = wheelSteeringAngle * turnInput;
		rightWheel.steerAngle = wheelSteeringAngle * turnInput;


        //moving the car forward and back
        float motorInput = 0;
		motorInput += (Input.GetKey (KeyCode.UpArrow)) ? 1 : 0;
		motorInput += (Input.GetKey (KeyCode.DownArrow)) ? -1 : 0;

		rearLeftWheel.motorTorque = motorTorque * motorInput;
		rearRightWheel.motorTorque = motorTorque * motorInput;


        //Applying our visual wheels, for te front and back
		VisualWheels (leftWheel);
		VisualWheels (rightWheel);
	}

    //Function for our visual wheels
	void VisualWheels (WheelCollider collider)
	{
        //Looking for children in our wheelcolliders
        //Child 0 is the visual wheel
		Transform visualWheel = collider.transform.GetChild (0);
        //Setting the local position and local rotation
		Vector3 position = collider.transform.localPosition;
		Quaternion rotation = collider.transform.localRotation;
        //Get the wheel world possition
		collider.GetWorldPose (out position, out rotation);

        //Set the wheel position and rotation
		visualWheel.transform.position = position;
		visualWheel.transform.rotation = rotation;

	}
}
