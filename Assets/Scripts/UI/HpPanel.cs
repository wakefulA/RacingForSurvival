using System.Collections.Generic;
using Player.PlayerHealth;
using UnityEngine;

namespace UI
{
    public class HpPanel : MonoBehaviour
    {
        [SerializeField] private GameObject _cellPrefab;
        [SerializeField] private PlayerHp _playerHp;

        private RectTransform _rectTransform;
        private readonly List<GameObject> _cells = new List<GameObject>();

        private void Awake()
        {
            _rectTransform = GetComponent<RectTransform>();
        }

        private void Start()
        {
            _playerHp.OnChanged += HpChanged;
            HpChanged(FindObjectOfType<Statistics>().HPCount);
            FindObjectOfType<Statistics>(). OnHpChanged += HpChanged;
        }

        private void OnDestroy()
        {
            _playerHp.OnChanged -= HpChanged;
        }

        private void HpChanged(int hp)
        {
            DestroyCurrentCells();
            CreateNewCell(hp);
        }

        private void CreateNewCell(int hp)
        {
            for (int i = 0; i < hp; i++)
            {
                GameObject cell = Instantiate(_cellPrefab, _rectTransform);
                _cells.Add(cell);
            }
        }

        private void DestroyCurrentCells()
        {
            foreach (GameObject cell in _cells)
            {
                Destroy(cell);
            }

            _cells.Clear();
        }
    }
}