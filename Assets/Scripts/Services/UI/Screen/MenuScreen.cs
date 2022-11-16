using Infrastructure.Launcher;
using Services.SceneLoading;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Services.UI.Screen
{
    public class MenuScreen : MonoBehaviour
    {
        [SerializeField] private Button _playButton;
        
        private ISceneLoadingService _sceneLoadingService;
        
        [Inject]
        public void Construct(ISceneLoadingService sceneLoadingService)
        {
            _sceneLoadingService = sceneLoadingService;
        }

        private void Awake()
        {
            _playButton.onClick.AddListener(OnPlayButtonClicked);
        }

        private void OnPlayButtonClicked()
        {
            
            
            _sceneLoadingService.Load(GameLauncher.SceneName);
            //TODO: Add  transition
        }
    }
}