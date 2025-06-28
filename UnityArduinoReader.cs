using UnityEngine;
using System.IO.Ports;

public class ArduinoReader : MonoBehaviour
{
    SerialPort serial = new SerialPort("COM3", 9600); // Change COM3 to match your port

    void Start()
    {
        serial.Open();
        serial.ReadTimeout = 100;
    }

    void Update()
    {
        if (serial.IsOpen)
        {
            try
            {
                string value = serial.ReadLine();
                Debug.Log("Arduino says: " + value);
                // You can parse value here and use it in Unity
            }
            catch (System.Exception)
            {
                // Handle read timeout or bad data
            }
        }
    }

    void OnApplicationQuit()
    {
        if (serial.IsOpen)
            serial.Close();
    }
}
