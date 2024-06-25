using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


namespace Project
{
    public class GamePlay_GameState : GameStateBase 
    { 
        public override void Enter()
        {
            SceneManager.LoadSceneAsync(2).completed += (operation) =>
            {
                Button mainMenuBack = Object.FindObjectOfType<Button>();
                mainMenuBack.onClick.AddListener(() =>
                {
                    _gameStateChanger.ChangeState(new Mainmenu_GameState());
                });
            };
        }
    }
}