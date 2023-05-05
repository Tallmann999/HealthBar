using UnityEngine;
using UnityEngine.Events;

public class PlayerStats : MonoBehaviour
{
    private float _minHealth = 0f;
    private float _maxHealth = 100f;

    public float CurrentHealth { get; private set; }
    public event UnityAction<float> OnHealthChange;

    private void Start()
    {
        CurrentHealth = _maxHealth;
    }

    public void AddHealth(float health)
    {
        CurrentHealth += health;
        CurrentHealth = Mathf.Clamp(CurrentHealth, _minHealth, _maxHealth);

        OnHealthChange?.Invoke(CurrentHealth);
    }

    public void RemoveHealth(float health)
    {
        CurrentHealth -= health;
        CurrentHealth = Mathf.Clamp(CurrentHealth, _minHealth, _maxHealth);

        OnHealthChange?.Invoke(CurrentHealth);
    }
}
