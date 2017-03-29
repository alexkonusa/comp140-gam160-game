using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class PortListener : MonoBehaviour
{
    //Port Name and Port Speed Public variables
    public string portName;
    public int portSpeed = 9600;

    //Data String
    public string dataString;

    //Input variables
    public int xInput;
    public int yInput;
    public int zInput;
    public int buttonOne;
    public int buttonTwo;

    SerialPort serialPort;

	// Use this for initialization
	void Start ()
    {

        //Set our port name to the one we found arduino on
        portName = GameObject.Find("GameManagers").GetComponent<GetActivePort>().PortName;

        serialPort = new SerialPort (portName, portSpeed); //set the serialport to use our name and speed variables
        serialPort.Open(); //Open a new serial port connection
        serialPort.ReadTimeout = 1; // error timeout 

	}

    void Update()
    {

        //Running our get data function
        GetData();

    }
	
    //This function does not work well with unity and arduino
    //Function for reading the data from Arduino 
   /* public string Data()
    {

        try
        {

            return serialPort.ReadLine();

        }

        catch (System.Exception )
        {

            return null;

        }

    }*/

    //Get Data function
    void GetData()
    {

        // try and read the serial port
        try
        {

            dataString = serialPort.ReadLine(); // datastring will hold our data that has been read
            ProcessData(); //Start the processing function

        }
        //Release resoarces that are iin our try block
        catch (System.Exception)
        {

            return;

        }

    }

    //Function to process the data.
    void ProcessData()
    {

        //If data string is not empty
        if (dataString != string.Empty )
        {
            //store data in currdata string
            string currData = dataString;

            //This is where we set an identifier which will sort the data
            //And store it into the right variable
            //Identifiers are set in our Arduino sketch
            if (currData.Substring(0, 1) == "A")
            {
                //if the first character is "X" then delete the char and place the data 
                //into a varible and process the number.
                currData = currData.Remove(0, 1);

                xInput = int.Parse(currData) / 100;

            }


            if (currData.Substring(0, 1) == "B")
            {
                currData = currData.Remove(0, 1);

                yInput = int.Parse(currData) / 100;

            }


            if (currData.Substring(0, 1) == "C")
            {
                currData = currData.Remove(0, 1);

                zInput = int.Parse(currData) / 100;

            }

            //Our button blocks
            if (currData.Substring(0, 1) == "D")
            {
                currData = currData.Remove(0, 1);

                buttonOne = int.Parse(currData);
            }

            if (currData.Substring(0, 1) == "E")
            {
                currData = currData.Remove(0, 1);

                buttonTwo = int.Parse(currData);
            }
        }
    }
}
