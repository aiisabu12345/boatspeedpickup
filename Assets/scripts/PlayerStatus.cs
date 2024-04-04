using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    [SerializeField] private float maxHealth;
    [SerializeField] private float maxStamina;

    private float currentHealth;
    private float currentStamina;

    public HealthBar healthBar;
    public StaminaBar staminaBar;

    private void Start()
    {
        currentHealth = maxHealth;
        currentStamina = maxStamina;

        healthBar.SetSliderMax(maxHealth);
        staminaBar.SetSliderMax(maxStamina);
    }

    private void Update()
    {

    }

    private void TakeDamage(float amount)
    {
        currentHealth -= amount;
        healthBar.SetSlider(currentHealth);
    }

    private void UseStamina(float amount)
    {
        currentStamina -= amount * Time.deltaTime;
        staminaBar.SetSlider(currentHealth);
    }
}
