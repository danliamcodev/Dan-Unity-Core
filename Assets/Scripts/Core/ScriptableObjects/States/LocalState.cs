using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace YourProject.Core.States
{
    [CreateAssetMenu(fileName = "State", menuName = "States/Local State")]
    public class LocalState : ScriptableObject
    {

    }

    [System.Serializable]
    public class LocalStateResponses
    {
        [Tooltip("State to register with.")]
        [SerializeField] LocalState _state;

        [Tooltip("Response to invoke when State is entered.")]
        [SerializeField] UnityEvent _onStateEnteredResponse;

        [Tooltip("Response to invoke when State is exited.")]
        [SerializeField] UnityEvent _onStateExitedResponse;

        public LocalState state => _state;
        public UnityEvent onStateEnteredResponse => _onStateEnteredResponse;
        public UnityEvent onStateExitedResponse => _onStateExitedResponse;
    }
}