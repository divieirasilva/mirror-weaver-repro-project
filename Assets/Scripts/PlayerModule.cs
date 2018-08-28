using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;

// #REMOVE HERE#
using UnityEngine.UI;

public class PlayerModule : NetworkBehaviour
{
    [SyncVar]
    public int PlayerId;

    // REMOVE THIS LINE AND THE "using UnityEngine.UI" TO MAKE THINGS WORK :D    
    // #REMOVE HERE#
    private Text someText = null;

    public override void OnStartServer()
    {
        if (PlayerId > 0)
            Debug.Log("(Server) Got Player Id: " + PlayerId);
        else
            Debug.LogError("(Server) Failed to get Player Id.");
    }

    public override void OnStartClient()
    {
        if (PlayerId > 0)
            Debug.Log("Got Player Id: " + PlayerId);
        else
            Debug.LogError("Failed to get Player Id.");
    }
}
