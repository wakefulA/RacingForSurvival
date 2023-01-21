using System;
using Infrastructure.Launcher;
using Infrastructure.Launcher.Services.SceneLoading;
using Infrastructure.LoadingScreen;
using Services.SceneLoading;
using UnityEngine;
using Zenject;

namespace Car
{
    public class CarDeath : MonoBehaviour
    {
       // [SerializeField] private GameObject _gameWinScreen;
        [SerializeField] private GameObject _carFollow;
        [SerializeField] private GameObject _carMove;
       // [SerializeField] public LoadingScreen _loadingScreen;
        //[SerializeField] private GameObject _loadScreen;

        [SerializeField] public CarSpawn _carSpawn;
        
        private ISceneLoadingService _sceneLoadingService;
        
        [Inject]
        public void Construct(ISceneLoadingService sceneLoadingService)
        {
            _sceneLoadingService = sceneLoadingService;
        }

       

        private void Awake()
        {
            _carSpawn.OnGameWinPlayer += GameWin;
        }

        private void OnDisable()
        {
            _carSpawn.OnGameWinPlayer -= GameWin;
        }


        private void SceneCheker()
        {
            
        }
        
        
        
        

        public void GameWin()
        {
            {
                _sceneLoadingService.Load(SceneNames.SecondScene);
              // _gameWinScreen.SetActive(true);
               // _gameOverScreen.SetActive(false);
                _carFollow.SetActive(false);
                _carMove.SetActive(false);
            }
        }
    }
}