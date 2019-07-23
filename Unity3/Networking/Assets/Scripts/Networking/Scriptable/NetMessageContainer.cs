using System;
using System.Collections.Generic;
using UnityEngine;

namespace LLNet
{
    [CreateAssetMenu(menuName = "LLNet/NetMessageContainer")]
    public class NetMessageContainer : ScriptableObject
    {
        [SerializeField]
        private ANetMessage[] _NetMessages;

        public Dictionary<NetMessageType, ANetMessage> NetMessageMap { get; private set; }

        private void OnEnable() 
        {
            MapMessages();
        }

        private void MapMessages()
        {
            NetMessageMap = new Dictionary<NetMessageType, ANetMessage>(_NetMessages.Length);

            foreach (var item in _NetMessages)
            {
                if(item == null || NetMessageMap.ContainsKey(item.MessageType))
                {
                    Debug.LogWarning($"Cannot Add Message [{item}]");
                }
                else
                {
                    NetMessageMap[item.MessageType] = item;
                }
            }
            Debug.Log($"Mapping Done! -> Added [{NetMessageMap.Count}] Messages");
        }

    }
}
