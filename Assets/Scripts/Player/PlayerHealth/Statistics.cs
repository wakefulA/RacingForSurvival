using System;
using Objects;
using UnityEngine;


namespace Player.PlayerHealth
{
    public class Statistics : SingletonMonoBehaviour<Statistics>
    {

        public int Iterator = 1;
        [SerializeField] public int HPCount = 4;
        [SerializeField] private PlayerHp _playerHp;
        
        
        public event Action<int> OnHpChanged;

        private void Start()
        {
            _playerHp.OnChanged += ChangeHpImage;
        }

        private void ChangeHpImage(int hp)
        {
            HPCount = hp;
            OnHpChanged?.Invoke(HPCount);
        }

        //public void NextImage()
        //{
           // Iterator++;
           // HPCount--;
        //}

        //protected virtual void OnOnHpChanged(int obj)
        //{
          //  OnHpChanged?.Invoke(obj);
        //}
    }
}