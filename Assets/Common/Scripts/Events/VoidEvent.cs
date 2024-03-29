﻿using UnityEngine;
using UnityEngine.Events;

namespace YourCompany.Events
{
    [CreateAssetMenu(fileName = "New Void Event", menuName = "Events/Void Event")]
    public class VoidEvent : BaseGameEvent<Void>
    {
        public void Raise()
        {
            Raise(new Void());
        }
    }

    [System.Serializable]
    public class VoidUnityEvent : UnityEvent<Void>
    {
        public void InvokeVoid()
        {
            Invoke(new Void());
        }
    }

    [System.Serializable] public struct Void { }
}