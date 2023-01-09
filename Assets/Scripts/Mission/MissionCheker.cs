using System;
using Car;
using Infrastructure.Launcher.Services.SceneLoading;
using Services.SceneLoading;
using Unity.VisualScripting;
using UnityEngine;
using Zenject;

namespace Mission
{
    public class MissionCheker : MonoBehaviour, IMissionCheker
    {

        [SerializeField] private CarSpawn _carSpawn;

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


        public void Ienumerator()
        {
            _carCount--;

            if (_carCount <= 0)
            {
                _sceneLoadingService.Load(SceneNames.SecondScene);
            }
        }
    }
}




/// сначала машины стучаться сюда, а потом мишин чекер стучится в сцен лоад сервис 