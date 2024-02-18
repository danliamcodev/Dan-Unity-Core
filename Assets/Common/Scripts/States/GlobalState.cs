using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace YourCompany.States
{
    [CreateAssetMenu(fileName = "State", menuName = "States/Global State")]
    public class GlobalState : ScriptableObject
    {
        private readonly List<GlobalStateListener> _stateListeners = new List<GlobalStateListener>();

        public void EnterState()
        {
            for (int i = _stateListeners.Count - 1; i >= 0; i--)
            {
                _stateListeners[i].OnStateEntered(this);
            }
        }

        public void ExitState()
        {
            for (int i = _stateListeners.Count - 1; i >= 0; i--)
            {
                _stateListeners[i].OnStateExited(this);
            }
        }

        public void RegisterListener(GlobalStateListener p_listener)
        {
            if (!_stateListeners.Contains(p_listener))
                _stateListeners.Add(p_listener);
        }

        public void UnregisterListener(GlobalStateListener p_listener)
        {
            if (_stateListeners.Contains(p_listener))
                _stateListeners.Remove(p_listener);
        }
    }

    [System.Serializable]
    public class GlobalStateResponses
    {
        [Tooltip("State to register with.")]
        [SerializeField] GlobalState _state;

        [Tooltip("Response to invoke when State is entered.")]
        [SerializeField] UnityEvent _onStateEnteredResponse;

        [Tooltip("Response to invoke when State is exited.")]
        [SerializeField] UnityEvent _onStateExitedResponse;

        public GlobalState state => _state;
        public UnityEvent onStateEnteredResponse => _onStateEnteredResponse;
        public UnityEvent onStateExitedResponse => _onStateExitedResponse;
    }
}
