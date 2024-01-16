using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("References")]
    [SerializeField] GlobalStateMachine _gameStateMachine;
    [Header("States")]
    [SerializeField] GlobalState _gameRunning;

    private void Awake()
    {
        _gameStateMachine.ClearState();
    }
}
