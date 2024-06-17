using JetBrains.Annotations;
using System;
using System.Collections.Generic;


[Serializable]
public class ServerList
{
    public List<Server> servers;
}

[Serializable]
public class Server
{
    public string name;
    public string ip;
    public int port;

    public string toString()
    {
        return "Server Name: " + name + "\nIP Address: " + ip + "\nPort: " + port;
    }
}