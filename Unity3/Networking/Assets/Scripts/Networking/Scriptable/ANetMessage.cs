using GameSavvy.Byterizer;
using UnityEngine;

namespace LLNet
{
    public abstract class ANetMessage : ScriptableObject
    {
        public NetMessageType MessageType;

        public abstract void Server_ReceiveMessage(int connectionId, ByteStream data, LLServer server);
        public abstract void Client_ReceiveMessage(ByteStream data, LLClient client);
    }
}
