using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class PortListener : MonoBehaviour
{
    //Port Name and Port Speed Public variables
    public string portName = "COM4";
    public int portSpeed = 9600;
    public string inputOne;
    public string inputTwo;
    public string inputThree;

    SerialPort serialPort;

	// Use this for initialization
	void Start ()
    {

        serialPort = new SerialPort (portName, portSpeed); //set the serialport to use our name and speed variables
        serialPort.Open(); //Open a new serial port connection
	
	}

    private void Update()
    {

        ProcessData();

    }
	
    //Function for reading the data from Arduino 
    public string Data()
    {

        try
        {

            return serialPort.ReadLine();

        }

        catch (System.TimeoutException)
        {

            return null;

        }

    }

    void ProcessData()
    {

        if (Data() != string.Empty )
        {

            string currData = Data();

            if (currData.Substring(0, 1) == "A")
            {
                inputOne = currData;
            }

            if (currData.Substring(0, 1) == "B")
            {
                inputTwo = currData;
            }

            if (currData.Substring(0, 1) == "C")
            {
                inputThree = currData;
            }
        }
    }
}
