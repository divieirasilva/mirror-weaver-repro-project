using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServerManager : MonoBehaviour
{
    [SerializeField]
    private NetworkManagerModule networkManagerModule;

    // Use this for initialization
    void Start()
    {
        Debug.Log("Server Starting...");
        networkManagerModule.networkAddress = "localhost";
        networkManagerModule.networkPort = 7777;
        networkManagerModule.maxConnections = 200;

        networkManagerModule.StartServer();
    }
}
