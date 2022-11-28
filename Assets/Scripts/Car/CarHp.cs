﻿using System;
using Player.PlayerHealth;
using UnityEngine;

namespace Car
{
    public class CarHp : MonoBehaviour, IHealth
    {
        [SerializeField] private int _startHp;
        [SerializeField] private int _maxHp;

        private void Awake()
        {
            CurrentHp = _startHp;
            OnChanged?.Invoke(CurrentHp);
        }

        public event Action<int> OnChanged;

        public int CurrentHp { get; private set; }
        public int MaxHp => _maxHp;

        public void ApplyDamage(int damage)
        {
            CurrentHp = Mathf.Max(0, CurrentHp - damage);
            OnChanged?.Invoke(CurrentHp);
        }

        public void ApplyHeal(int heal)
        {
            CurrentHp = Mathf.Min(_maxHp, CurrentHp + heal);
            OnChanged?.Invoke(CurrentHp);
        }
    }
}