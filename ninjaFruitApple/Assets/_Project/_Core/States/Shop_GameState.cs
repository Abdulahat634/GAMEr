using So;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Project.UI;

namespace Project
{
    public class Shop_GameState : GameStateBase
    {

        private UiContainer _uiContainer;
        private IUBase _shopUI;
        private Button _backButton;
        private Button _shopButton;
        public override void Enter()
        {
            _uiContainer = Resources.Load<UiContainer>
                ("Configs/UIContainerNew_Year" + _gameStateChanger.dayType.ToString());

            SceneManager.LoadSceneAsync(3).completed += (_) =>
            {
                _shopUI = Object.Instantiate(_uiContainer.GetUI("Shop"));

                _backButton = _shopUI.transform.Find("Back").GetComponent<Button>();
                _backButton.onClick.AddListener(GoBack);

            };
        }

        private void GoBack() 
        {
            _gameStateChanger.ChangeState(new Shop_GameState());
        }
    }
}