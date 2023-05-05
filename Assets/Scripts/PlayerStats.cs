using UnityEngine;
using UnityEngine.Events;

public class PlayerStats : MonoBehaviour
{
    private float _minHealth = 0f;
    private float _maxHealth = 100f;

    public float CurrentHealth { get; private set; }
    public event UnityAction<float> HealthChange;

    private void Start()
    {
        CurrentHealth = _maxHealth;
    }

    public void Heal(float health)
    {
        CurrentHealth += health;
        CurrentHealth = Mathf.Clamp(CurrentHealth, _minHealth, _maxHealth);

        HealthChange?.Invoke(CurrentHealth);
    }

    public void Damage(float damage)
    {
        CurrentHealth -= damage;
        CurrentHealth = Mathf.Clamp(CurrentHealth, _minHealth, _maxHealth);

        HealthChange?.Invoke(CurrentHealth);
    }
}
