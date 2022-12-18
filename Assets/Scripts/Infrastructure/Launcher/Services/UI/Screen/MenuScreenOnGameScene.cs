using System;
using UnityEngine;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;

namespace Infrastructure.Launcher.Services.UI.Screen
{
    public class MenuScreenOnGameScene : MonoBehaviour
    {
        [SerializeField] private Button _backToGameButton;
        [SerializeField] private Button _quitButton;

        [SerializeField] private GameObject _pauseScreen;
        [SerializeField] private GameObject _menuScreenOnGameScene;

        private void Awake()
        {
            _backToGameButton.onClick.AddListener(OnBackToGameButton);
            _quitButton.onClick.AddListener(OnQuitButton);
        }

       private void Start()
       {
            _pauseScreen.SetActive(false);
       }

        private void OnQuitButton()
        {
            Application.Quit();
        }

        private void OnBackToGameButton()
        {
            _menuScreenOnGameScene.SetActive(false);
            Time.timeScale = 1f;


        }
    }
}