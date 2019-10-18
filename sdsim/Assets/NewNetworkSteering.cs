using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Net;
using System;

public class NewNetworkSteering : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TcpListener server = new TcpListener(IPAddress.Parse("127.0.0.1"), 9090);

        server.Start();
        Console.WriteLine("Server has started on 127.0.0.1:80.{0}Waiting for a connection...", Environment.NewLine);

        TcpClient client = server.AcceptTcpClient();

        Console.WriteLine("A client connected.");
    }

    // Update is called once per frame
    void Update()
    {
        //TcpListener server = new TcpListener(IPAddress.Parse("127.0.0.1"), 9090);

        //server.Start();
        //Console.WriteLine("Server has started on 127.0.0.1:80.{0}Waiting for a connection...", Environment.NewLine);

        //TcpClient client = server.AcceptTcpClient();

        //Console.WriteLine("A client connected.");
    }
}
