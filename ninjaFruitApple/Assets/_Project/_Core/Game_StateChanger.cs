using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Project
{
    public enum DayType { Usual, Holloween, NewYear}
    public class Game_StateChanger : MonoBehaviour
    {
        public DayType dayType = DayType.Usual;
        private GameStateBase _currentState;
        void Start()
        {
            ChangeState(new Mainmenu_GameState());
        }

        public void ChangeState(GameStateBase newGameStatebase)
        {
            _currentState?.Exit();

            _currentState = newGameStatebase;
            _currentState.SetGameStateChanger(this);
            _currentState?.Enter();
        }
    }
}