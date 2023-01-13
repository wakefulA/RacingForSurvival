using UnityEngine;

namespace Car
{
    public class CarDeath : MonoBehaviour
    {
        [SerializeField] private GameObject _gameWinScreen;
        [SerializeField] private GameObject _carFollow;
        [SerializeField] private GameObject _carMove;

        [SerializeField] public CarSpawn _carSpawn;

        private void Awake()
        {
            _carSpawn.OnGameWinPlayer += GameWin;
        }

        private void OnDisable()
        {
            _carSpawn.OnGameWinPlayer -= GameWin;
        }

        private void GameWin()
        {
            {
                _gameWinScreen.SetActive(true);
                _carFollow.SetActive(false);
                _carMove.SetActive(false);
            }
        }
    }
}