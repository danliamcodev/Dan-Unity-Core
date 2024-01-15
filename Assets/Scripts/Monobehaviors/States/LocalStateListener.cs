using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LocalStateListener : MonoBehaviour
{
    [Header("References")]
    [SerializeField] LocalStateMachine _stateMachine;
    [Header("Parameters")]
    [SerializeField] List<LocalStateResponses> _stateResponses;
    Dictionary<LocalState, UnityEvent> _onStateEnteredResponses = new Dictionary<LocalState, UnityEvent>();
    Dictionary<LocalState, UnityEvent> _onStateExitedResponses = new Dictionary<LocalState, UnityEvent>();

    private void Awake()
    {
        foreach (LocalStateResponses stateResponses in _stateResponses)
        {
            _onStateEnteredResponses.Add(stateResponses.state, stateResponses.onStateEnteredResponse);
            _onStateExitedResponses.Add(stateResponses.state, stateResponses.onStateExitedResponse);
        }
    }

    private void OnEnable()
    {
        foreach (LocalStateResponses stateResponses in _stateResponses)
        {
            _stateMachine.RegisterListener(stateResponses.state, this);
        }
    }

    private void OnDisable()
    {
        foreach (LocalStateResponses stateResponses in _stateResponses)
        {
            _stateMachine.UnregisterListener(stateResponses.state, this);
        }
    }

    public void OnStateEntered(LocalState p_state)
    {
        _onStateEnteredResponses[p_state].Invoke();
    }


    public void OnStateExited(LocalState p_state)
    {
        _onStateExitedResponses[p_state].Invoke();
    }
}
