using Services.SceneLoading;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Infrastructure.Launcher.Services.UI.Screen
{
    public class MenuScreen : MonoBehaviour
    {
        [Header("Button")]
        [SerializeField] private Button _playButton;
        [SerializeField] private Button _quitButton;

        [Header("Game Object")]
        [SerializeField] private GameObject _menuScreenOff;
        [SerializeField] private GameObject _loadScreen;

        private ISceneLoadingService _sceneLoadingService;

        [Inject]
        public void Construct(ISceneLoadingService sceneLoadingService)
        {
            _sceneLoadingService = sceneLoadingService;
        }

        private void Awake()
        {
            _playButton.onClick.AddListener(OnPlayButtonClicked);
            _quitButton.onClick.AddListener(OnQuitButtonClicked);
        }

        private void OnPlayButtonClicked()
        {
            _loadScreen.SetActive(true);
            _menuScreenOff.SetActive(false);
            _sceneLoadingService.Load(GameLauncher.SceneName);
        }

        private void OnQuitButtonClicked()
        {
            Debug.LogError("The end");
            Application.Quit();
        }
    }
}