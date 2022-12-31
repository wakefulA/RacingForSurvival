using System;
using Player.PlayerHealth;
using UnityEngine;

namespace Car
{
    public class CarDeath : MonoBehaviour
    {
        [SerializeField] public CarSpawn _carSpawn;
        [SerializeField] public PlayerHp _PlayerHp;
        [SerializeField] private Statistics _statistics;
        [SerializeField] private GameObject _gameWinScreen;
        [SerializeField] private GameObject _carFollow;
        [SerializeField] private GameObject _carMove;

        

        private void GameWin()
        {
            // for (int i = 0; i < _carSpawn.cars.Length;)
            {
                _gameWinScreen.SetActive(true);
                _carFollow.SetActive(false);
                _carMove.SetActive(false);
            }
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