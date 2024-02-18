using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YourCompany.States;

namespace YourCompany.GameLogic.Managers
{
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
}