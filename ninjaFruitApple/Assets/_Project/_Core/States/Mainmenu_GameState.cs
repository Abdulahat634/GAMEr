using So;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Project.UI;

namespace Project
{

    public class Mainmenu_GameState : GameStateBase
    {
        private UiContainer _uiContainer;

        private IUBase _mainMenu;
        private Button _playButton;

        private Button _shopButton;
        public override void Enter()
        {
            _uiContainer = Resources.Load<UiContainer>("Configs/UIContainerNew_Year" + _gameStateChanger.dayType.ToString());

            SceneManager.LoadSceneAsync(1).completed += (operation) =>
            {
                IUBase mainMenuPrefab = _uiContainer.GetUI("MainMenu");
                _mainMenu = Object.Instantiate(mainMenuPrefab);

                _playButton = _mainMenu.transform.Find("StartButton").GetComponent<Button>();
                _playButton.onClick.AddListener(GoToGampleay);

                _shopButton = _mainMenu.transform.Find("Shop").GetComponent<Button>();
                _shopButton.onClick.AddListener(GoToShop);
            };
        }

        private void GoToGampleay()
        {
            _gameStateChanger.ChangeState(new GamePlay_GameState());
        }

        private void GoToShop()
        {
            _gameStateChanger.ChangeState(new Shop_GameState());
        }
    }
       
        

    
}