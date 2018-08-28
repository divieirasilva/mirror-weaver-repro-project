using Mirror;
using UnityEngine;

public class PlayerSpawnNetworkMessage : MessageBase
{
    public int PlayerId;
    public int AccountId;
    public Vector3 Position;
}