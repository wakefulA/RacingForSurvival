using System;
using System.Collections;
using Player.PlayerHealth;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Car
{
    public class CarSpawn : MonoBehaviour
    {
        [SerializeField] private PlayerHp _playerHp;
        [SerializeField] private GameObject _carFollow;
        [SerializeField] private GameObject _carMove;
        [SerializeField] private GameObject _gameOverScreen;

        public GameObject[] cars;
        private float[] positions = {1.09f, 3.47f, -3.31f, -1.15f};

        public int CountCar { get; private set; } = 5;

        public event Action OnGameWinPlayer;

        private void Awake()
        {
            _playerHp.OnGameOverPlayer += GameOver;
        }

        private void Start()
        {
            StartCoroutine(Spawn());
        }

        private void OnDisable()
        {
            _playerHp.OnGameOverPlayer -= GameOver;
        }

        public IEnumerator Spawn()
        {
            for (int i = 0; i < CountCar; i++)
            {
                Instantiate(cars[Random.Range(0, cars.Length)], new Vector3(positions[Random.Range(0, 4)], 6.5f, 0),
                    Quaternion.Euler(new Vector3(-90, 360, 0)));


                yield return new WaitForSeconds(2.5f);
            }

            if (_playerHp.CurrentHp > 0)
            {
                OnGameWinPlayer?.Invoke();
            }
        }

        public void GameOver()
        {
            if (_playerHp.CurrentHp == 0)
            {
                _gameOverScreen.SetActive(true);
                _carFollow.SetActive(false);
                _carMove.SetActive(false);
            }
        }
    }
}