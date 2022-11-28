﻿using System;

namespace Player.PlayerHealth
{
    public interface IHealth
    {
        int CurrentHp { get; }
        int MaxHp { get; }
        event Action<int> OnChanged;

        void ApplyDamage(int damage);
        void ApplyHeal(int heal);
    }
}