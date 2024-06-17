using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetworkManager : MonoBehaviour
{
    public NetworkManager netManager;

    //Constructor
    NetworkManager()
    {

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
}
