using System;
using UnityEngine;


namespace Player.PlayerHealth
{
    public class PlayerHp : MonoBehaviour, IHealth

    {
        [SerializeField] private int _startHp;
        [SerializeField] private int _maxHp;

        
        public event Action<int> OnChanged;
        
        public event Action OnGameOverPlayer; 

        public int CurrentHp { get; private set; }
        public int MaxHp => _maxHp;
        
        private void Awake()
        {
            CurrentHp = _startHp;
            OnChanged?.Invoke(CurrentHp);
        }

       
        public void ApplyDamage(int damage)
        {
            CurrentHp = Mathf.Max(0, CurrentHp - damage);
            OnChanged?.Invoke(CurrentHp);
            OnGameOverPlayer?.Invoke();
        }

        public void ApplyHeal(int heal)
        {
            CurrentHp = Mathf.Min(_maxHp, CurrentHp + heal);
            OnChanged?.Invoke(CurrentHp);
        }
    }
}
    