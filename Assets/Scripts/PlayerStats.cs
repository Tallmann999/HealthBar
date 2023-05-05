using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerStats : MonoBehaviour
{
    public float MaxHealth { get; private set; } = 100f;

    public event UnityAction<float> OnHealthChange;

    public void AddHealth(float health)
    {
        MaxHealth += health;
        OnHealthChange?.Invoke(MaxHealth);
    }

    public void RemoveHealth(float health)
    {
        MaxHealth -= health;
        OnHealthChange?.Invoke(MaxHealth);
    }
}
