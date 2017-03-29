using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO.Ports;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GetActivePort : MonoBehaviour
{
    //This will list all of our current ports 
    public List<string> AvaliblePorts = new List<string>();
    public int portSpeed = 9600;
    public string message;
    public string PortName;
    public string restartSceneName;
    public string gameStartSceneName;
    public Text messageText;

    //Declaring our restart and serialPort variables
    SerialPort serialPort;
    RestartGame restartGame;

    void Awake()
    {
        //Dont destroy this script when we load a 
        //new scene so that we can use the port we found.
        DontDestroyOnLoad(this);
    }

    // Use this for initialization
    void Start ()
    {

        //List all of our avalible ports in the list
        AvaliblePorts.AddRange(SerialPort.GetPortNames());
    }

    void Update()
    {

        //Run the attempt to find the arduino
        AttemptToFindThePort();

    }

    //Check our port for arduino
    void CheckPort()
    {

        //For each listed port
        for (int i = 0; i < AvaliblePorts.Count; i++)
        {

            //Declare a new serial port using the name in the list and the speed
            serialPort = new SerialPort(AvaliblePorts[i], portSpeed);

            //Display a message
            messageText.text = "Trying Port: " + AvaliblePorts[i];

            //Open up the port
            serialPort.Open();
            serialPort.ReadTimeout = 1;

            //If serial port is avalible and is open
            if (serialPort != null && serialPort.IsOpen)
            {
                //we try to read data from it and store it in the message variable
                try
                {

                    message = serialPort.ReadLine();

                    //If message is not empty = we have found our arduino
                    if (message != string.Empty)
                    {
                        //Display the message
                        messageText.text = "Arduino Has Been Found on Port: " + AvaliblePorts[i];

                        //Set the port name to the current port in the list and close the serialport
                        PortName = AvaliblePorts[i];
                        serialPort.Close();
                        break;

                    }
                }

                //If there is an error display the error
                catch (System.TimeoutException err)
                {

                    print(err);

                }

                messageText.text = "Looking for Arduino! " + "If waiting for more than 20seconds please Press R to RETRY";

                //if message above is displayed for a long time 
                //player can restart and re-try by pressing R
                if (Input.GetKeyDown(KeyCode.R))
                {

                    SceneManager.LoadScene(gameStartSceneName);

                }

                serialPort.Close(); // Close the port if we didnt find the arduino
            }

        }

    }

 //Attempt to find the port function
    void AttemptToFindThePort()
    {
        //if both message and portname are empty then run the checkport function
        if (message == string.Empty && PortName == string.Empty)
        {

            CheckPort();

        }

        //if portname is not empty display the sucess message and allow the player to start the game
        if (PortName != string.Empty)
        {

            messageText.text = "Arduino has been found! Press S to start the GAME";

            //Now that we found our port we can start our game
            if (Input.GetKeyDown(KeyCode.S))
            {

                SceneManager.LoadScene(gameStartSceneName);

            }
        }
    }
}
