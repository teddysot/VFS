namespace LLNet
{
    public enum NetMessageType : byte
    {
        CONNECTION_ACK,
        DISCONNECTION_ACK,
        USER_INFO,
        CHAT_WHISPER,
        CHAT_BROADCAST,
        CHAT_TEAM_MESSAGE
    }

}// Namescape