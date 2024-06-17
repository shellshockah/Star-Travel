using Palmmedia.ReportGenerator.Core.Common;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetworkManager : MonoBehaviour
{
    public static NetworkManager netManager;
    public ServerList serverList;

    //Constructor
    NetworkManager()
    {
        getServerList();
    }

    // MonoBehaviour Override Funcs
    void Start()
    {
        if(netManager == null)
        {
            netManager = new NetworkManager();
        }
    }

    void Update()
    {
        
    }

    public void getServerList()
    {
        serverList = JSONUtils.deserialize<ServerList>(JSONUtils.getJsonStr("./Assets/Network/src/Data/Servers.json"));
        for(int i = 0; i < serverList.servers.Count; i++)
            Debug.Log(serverList.servers[i].toString());
    }
}
  