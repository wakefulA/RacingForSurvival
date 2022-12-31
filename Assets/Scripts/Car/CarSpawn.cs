using System;
using System.Collections;
using Player.PlayerHealth;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Car
{
    public class CarSpawn : MonoBehaviour
    {
        public GameObject[] cars;
        private float[] positions = {1.09f, 3.47f, -3.31f, -1.15f};

        [SerializeField] private PlayerHp _playerHp;
        [SerializeField] private GameObject _carFollow;
        [SerializeField] private GameObject _carMove;

        [SerializeField] private GameObject _gameOverScreen;

        
        public event Action OnGameWinPlayer;
       

        private void GameOver()
        {
            if (_playerHp.CurrentHp == 0)
            {
                _carFollow.SetActive(false);
                _carMove.SetActive(false);
                _gameOverScreen.SetActive(true);
            }
        }

        private void Awake()
        {
            _playerHp.OnGameOverPlayer += GameOver;
        }

        private void OnDisable()
        {
            _playerHp.OnGameOverPlayer -= GameOver;
        }

        private void Start()
        {
          
            StartCoroutine(Spawn());
        }

       

        public IEnumerator Spawn()
        {
         
            
            for (int i = 0; i < 2; i++)
            {
                Instantiate(cars[Random.Range(0, cars.Length)], new Vector3(positions[Random.Range(0, 4)], 6.5f, 0),
                    Quaternion.Euler(new Vector3(-90, 360, 0)));


                yield return new WaitForSeconds(2.5f);
            }
            
            OnGameWinPlayer?.Invoke();
        }
        
    }
}