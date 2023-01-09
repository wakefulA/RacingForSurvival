using Infrastructure.Launcher.Services.SceneLoading;
using Services.SceneLoading;
using UnityEngine;
using Zenject;

namespace Car
{
    public class CarDeath : MonoBehaviour
    {
        [SerializeField] public CarSpawn _carSpawn;
        [SerializeField] private GameObject _gameWinScreen;
        [SerializeField] private GameObject _gameOverScreen;
        [SerializeField] private GameObject _carFollow;
        [SerializeField] private GameObject _carMove;

        private ISceneLoadingService _sceneLoadingService;

        [Inject]
        public void Construct(ISceneLoadingService sceneLoadingService)
        {
            _sceneLoadingService = sceneLoadingService;
        }

        private void GameWin()
        {
            
            _sceneLoadingService.Load(SceneNames.SecondScene);
            _gameWinScreen.SetActive(true);
            _gameOverScreen.SetActive(false);
            _carFollow.SetActive(false);
            _carMove.SetActive(false);
        }

        private void Awake()
        {
            _carSpawn.OnGameWinPlayer += GameWin;
        }

        private void OnDisable()
        {
            _carSpawn.OnGameWinPlayer -= GameWin;
        }
    }
}