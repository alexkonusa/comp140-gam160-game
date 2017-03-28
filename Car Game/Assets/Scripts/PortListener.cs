using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class PortListener : MonoBehaviour
{
    //Port Name and Port Speed Public variables
    public string portName = "COM4";
    public int portSpeed = 9600;
    public int xInput;
    public int yInput;

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

                currData = currData.Remove(0, 1);

                xInput = int.Parse(currData) / 31;
            }

            if (currData.Substring(0, 1) == "B")
            {
                currData = currData.Remove(0, 1);

                yInput = int.Parse(currData) / 100;
            }

        }
    }
}
