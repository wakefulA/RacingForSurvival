using Car;
using Infrastructure.Launcher.Services.SceneLoading;
using Infrastructure.LoadingScreen;
using Player.PlayerHealth;
using Services.SceneLoading;
using UnityEngine;
using Zenject;

namespace Mission
{
    public class MissionCheker : MonoBehaviour, IMissionCheker
    {
        
        [SerializeField] private CarSpawn _carSpawn;
        [SerializeField] private PlayerHp _playerHp;
        //[SerializeField] private CarDeath _carDeath;
        [SerializeField] private GameObject _winGameScreen;

        private int _carCount;
        
        private void Start()
        {
            _carCount = _carSpawn.CountCar;

        }
        
        private ISceneLoadingService _sceneLoadingService;
        

        [Inject]
        
        public void Construct(ISceneLoadingService sceneLoadingService)
        {
            _sceneLoadingService = sceneLoadingService;
        }


        public void IenumeratorCarCount()
        {
            _carCount--;

            if (_carCount <= 0)
            {
                _sceneLoadingService.Load(SceneNames.SecondScene);
            }
            
             
            
        }

        public void IenumeratorCarHP()
       {
           if (_playerHp.CurrentHp > 0)
           {
               _winGameScreen.SetActive(true);
           }
       }
        
        
    }
}