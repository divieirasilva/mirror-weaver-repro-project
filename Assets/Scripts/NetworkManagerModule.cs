using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;

public class NetworkManagerModule : NetworkManager
{
    public override void OnClientSceneChanged(NetworkConnection conn)
    {
        if (!ClientScene.ready && ClientScene.Ready(conn))
        {
            var msg = new PlayerSpawnNetworkMessage
            {
                AccountId = 1,
                PlayerId = 2,
                Position = Vector3.up
            };

            ClientScene.AddPlayer(conn, 0, msg);
        }
    }

    public override void OnServerAddPlayer(NetworkConnection conn, short playerControllerId)
    {
        Debug.LogError("Called the wrong OnServerAddPlayer");
    }

    public override void OnServerAddPlayer(NetworkConnection conn, short playerControllerId, NetworkReader extraMessageReader)
    {
        Debug.Log("Called the correct OnServerAddPlayer");

        var spawnMessage = extraMessageReader.ReadMessage<PlayerSpawnNetworkMessage>();

        var player = Instantiate(playerPrefab, spawnMessage.Position, Quaternion.identity) as GameObject;

        // Should go to the database and get player
        // Inventory, skills, etc will be set here
        var playerModule = player.GetComponent<PlayerModule>();
        playerModule.PlayerId = spawnMessage.PlayerId;

        NetworkServer.Spawn(player);
    }
}
