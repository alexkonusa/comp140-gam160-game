using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class PortListener : MonoBehaviour
{
    //Port Name and Port Speed Public variables
    public string portName = "COM4";
    public int portSpeed = 9600;

    SerialPort serialPort;

	// Use this for initialization
	void Start ()
    {

        
        serialPort = new SerialPort (portName, portSpeed); //set the serialport to use our name and speed variables
        serialPort.Open(); //Open a new serial port connection
        serialPort.ReadTimeout = 1; //time before timeout
	
	}

    private void Update()
    {

        Debug.Log(Data());
        
    }
	
    //Function for reading the data from Arduino 
    public string Data()
    {

        try
        {

            return serialPort.ReadLine();

        }

        catch (System.Exception)
        {

            return null;

        }
    }
}
