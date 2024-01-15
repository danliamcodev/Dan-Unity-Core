using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GlobalStateListener : MonoBehaviour
{
    [Header("Parameters")]
    [SerializeField] List<GlobalStateResponses> _stateResponses;
    Dictionary<GlobalState, UnityEvent> _onStateEnteredResponses = new Dictionary<GlobalState, UnityEvent>();
    Dictionary<GlobalState, UnityEvent> _onStateExitedResponses = new Dictionary<GlobalState, UnityEvent>();

    private void Awake()
    {
        foreach (GlobalStateResponses stateResponses in _stateResponses)
        {
            _onStateEnteredResponses.Add(stateResponses.state, stateResponses.onStateEnteredResponse);
            _onStateExitedResponses.Add(stateResponses.state, stateResponses.onStateExitedResponse);
        }
    }

    private void OnEnable()
    {
        foreach (GlobalStateResponses stateResponses in _stateResponses)
        {
            stateResponses.state.RegisterListener(this);
        }
    }

    private void OnDisable()
    {
        foreach (GlobalStateResponses _stateResponses in _stateResponses)
        {
            _stateResponses.state.UnregisterListener(this);
        }
    }

    public void OnStateEntered(GlobalState p_state)
    {
        _onStateEnteredResponses[p_state].Invoke();
    }


    public void OnStateExited(GlobalState p_state)
    {
        _onStateExitedResponses[p_state].Invoke();
    }
}
