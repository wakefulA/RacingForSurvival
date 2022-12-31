using UnityEngine;
using UnityEngine.UI;

namespace Infrastructure.Launcher.Services.UI.Screen
{
    public class MenuScreen : MonoBehaviour
    {
        [SerializeField] private Button _playButton;
        [SerializeField] private Button _quitButton;
      

        [SerializeField] private GameObject _loadScreen;
        

       

        // private ISceneLoadingService _sceneLoadingService;
        //
        // [Inject]
        // public void Construct(ISceneLoadingService sceneLoadingService)
        // {
        //     _sceneLoadingService = sceneLoadingService;
        // }

        private void Awake()
        {
            _playButton.onClick.AddListener(OnPlayButtonClicked);
            _quitButton.onClick.AddListener(OnQuitButtonClicked);
        }

       

       private void OnPlayButtonClicked()
        {
            
            //_menuScreen.SetActive(false);
           _loadScreen.SetActive(true);

            //_sceneLoadingService.Load(GameLauncher.SceneName);
            //TODO: Add  transition
        }

        private void OnQuitButtonClicked()
        {
            Debug.LogError("The end");
            Application.Quit();
        }
    }
}