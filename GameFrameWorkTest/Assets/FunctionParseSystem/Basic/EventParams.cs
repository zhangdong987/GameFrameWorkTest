using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

    public enum EventNetSyncObjectTypes
    {
        NONE,
        BOTH,
        SELF_ONLY,
        TARGET_ONLY,
    }

    public class EventParams
    {
        //public CMainPlayer playerData;
        public object[] parameters;

        public EventParams() {
        }

        public EventParams(params object[] args) {
            parameters = args;
        }

        public void Reset()
        {
        }

        static Dictionary<int, EventNetSyncObjectTypes> validEvent = new Dictionary<int, EventNetSyncObjectTypes>();
        public static void EnableEventNetSync(string eventName, EventNetSyncObjectTypes type)
        {
            validEvent[eventName.GetHashCode()] = type;
        }
    }