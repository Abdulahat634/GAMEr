using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Project
{
    public class GameStateBase 
    {
        public Game_StateChanger _gameStateChanger;

        public void SetGameStateChanger(Game_StateChanger gameStateChanger)
        {
            _gameStateChanger = gameStateChanger;
        }
        public virtual void Enter()
        {

        }
        public virtual void Process()
        {

        }
        public virtual void Exit() 
        {
            
        }
    }
}