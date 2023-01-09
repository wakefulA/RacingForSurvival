using System;
using System.Collections;
using Infrastructure.Launcher.Services.HP;
using Player.PlayerHealth;
using Unity.VisualScripting;
using UnityEngine;
using Zenject;
using FixedUpdate = UnityEngine.PlayerLoop.FixedUpdate;
using Random = UnityEngine.Random;

namespace Car
{
    public class CarSpawn : MonoBehaviour
    {
        public GameObject[] cars;
        private float[] positions = {1.09f, 3.47f, -3.31f, -1.15f};

        [SerializeField] private GameObject _carFollow;
        [SerializeField] private GameObject _carMove;
        [SerializeField] private GameObject _gameWinScreen;

        [SerializeField] private GameObject _gameOverScreen;

        private HPService _hpService;

        [Inject]
        public void Construct(HPService hpService)
        {
            _hpService = hpService;
        }

        public int CountCar { get; private set; } = 2;

        public event Action OnGameWinPlayer;

        public void GameOver()
        {
            if (_hpService.HP == 0)
            {
                _gameOverScreen.SetActive(true);
                _gameWinScreen.SetActive(false);
                _carFollow.SetActive(false);
                _carMove.SetActive(false);
            }
        }

        private void Start()
        {
            StartCoroutine(Spawn());
        }

        public IEnumerator Spawn()
        {
            for (int i = 0; i < CountCar; i++)
            {
                Instantiate(cars[Random.Range(0, cars.Length)], new Vector3(positions[Random.Range(0, 4)], 6.5f, 0),
                    Quaternion.Euler(new Vector3(-90, 360, 0)));


                yield return new WaitForSeconds(2.5f);
            }

            if (_hpService.HP > 0)
            {
                OnGameWinPlayer?.Invoke();
            }
        }
    }
}