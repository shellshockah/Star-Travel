using Palmmedia.ReportGenerator.Core.Common;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientNetworkManager : MonoBehaviour
{
    public static ClientNetworkManager netManager;
    public ServerList serverList;

    //Constructor
    ClientNetworkManager()
    {
        getServerList();
    }

    // MonoBehaviour Override Funcs
    void Start()
    {
        if(netManager == null)
        {
            netManager = new ClientNetworkManager();
        }
    }

    void Update()
    {
        
    }

    public void getServerList()
    {
        serverList = JSONUtils.deserialize<ServerList>(JSONUtils.getJsonStr("./Assets/Network/src/Client/Data/ServerList.json"));
        for(int i = 0; i < serverList.servers.Count; i++)
            Debug.Log(serverList.servers[i].toString());
    }
}
  