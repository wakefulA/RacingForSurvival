using System.Collections.Generic;
using Infrastructure.Launcher.Services.HP;
using Player.PlayerHealth;
using UnityEngine;
using Zenject;

namespace UI
{
    public class HpPanel : MonoBehaviour
    {
        [SerializeField] private GameObject _cellPrefab;

        private RectTransform _rectTransform;
        private readonly List<GameObject> _cells = new List<GameObject>();

        private HPService _hpService;

        [Inject]
        public void Construct(HPService hpService)
        {
            _hpService = hpService;
        }

        private void Awake()
        {
            _rectTransform = GetComponent<RectTransform>();
        }

        private void Start()
        {
            //_playerHp.OnChanged += HpChanged;
            // HpChanged(FindObjectOfType<Statistics>().);
            //  FindObjectOfType<Statistics>().OnHpChanged += HpChanged;
        }

        public void HpChanged(int hp)
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