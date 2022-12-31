using Player;
using Player.PlayerHealth;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Infrastructure.Launcher.Services.UI.Screen
{
    public class GameOverScreen : MonoBehaviour
    {
        [SerializeField] private Button _restartButton;
        [SerializeField] private Button _quitButton;

        [SerializeField] private GameObject _loadScreen;
        [SerializeField] private GameObject _newCell;

        // [SerializeField] private GameObject _loadScreen;

        // private ISceneLoadingService _sceneLoadingService;
        //
        // [Inject]
        // public void Construct(ISceneLoadingService sceneLoadingService)
        // {
        //     _sceneLoadingService = sceneLoadingService;
        // }

        private void Awake()
        {
            _restartButton.onClick.AddListener(OnRestartButtonClicked);
            _quitButton.onClick.AddListener(OnQuitButtonClicked);
        }

        private void OnRestartButtonClicked()
        {
            //_menuScreen.SetActive(false);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
            _newCell.SetActive(true);


            _loadScreen.SetActive(true);


            //TODO: Add  transition
        }

        private void OnQuitButtonClicked()
        {
            Debug.LogError("The end");
            Application.Quit();
        }
    }
}