﻿using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Infrastructure.Launcher.Services.UI.Screen
{
    public class GameWinScreen : MonoBehaviour
    
    {
        [SerializeField] private Button _restartButton;
        [SerializeField] private Button _quitButton;
        
        [SerializeField] private GameObject _newCell;
        
        
        private void Awake()
        {
            _restartButton.onClick.AddListener(OnRestartButtonClicked);
            _quitButton.onClick.AddListener(OnQuitButtonClicked);
        }

        private void OnRestartButtonClicked()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
            _newCell.SetActive(true);
        }

        private void OnQuitButtonClicked()
        {
            Debug.LogError("The end");
            Application.Quit();
        }
        
    }
}