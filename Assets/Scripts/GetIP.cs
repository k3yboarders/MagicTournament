using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Net;
public class GetIP : MonoBehaviour
{
    //[SerializeField]
    //private Text WelcomeIPText;
    [SerializeField]
    private Text NormalIPText;
    void Start()
    {
        GetUserIP();
    }

    void Update()
    {
        
    }
    public void GetUserIP()
    {
        string IPAddress = "";
        IPHostEntry Host = default(IPHostEntry);
        string Hostname = null;
        Hostname = System.Environment.MachineName;
        Host = Dns.GetHostEntry(Hostname);
        foreach (IPAddress IP in Host.AddressList)
        {
            if (IP.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
            {
                IPAddress = IP.ToString();
            }
        }
        //WelcomeIPText.text = "Twoje IP: " + IPAddress;
        NormalIPText.text = "Twoje IP: " + IPAddress;

        //Debug.Log(IPAddress);
    }

}
