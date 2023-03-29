using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] private float _maxHealth = 5;
    private float _currentHealth;

    [SerializeField] private Healthbar _healthbar;

    // Start is called before the first frame update
    void Start()
    {
        _currentHealth = _maxHealth;

        _healthbar.UpdateHealthBar(_maxHealth, _currentHealth);
    }

    public void PlayerDamage(int amount)
    {
        _currentHealth -= amount;
        if (_currentHealth <= 0f)
        {
            SceneManager.LoadScene(0);
        }
        else
        {
            _healthbar.UpdateHealthBar(_maxHealth, _currentHealth);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Projectile"))
        {
            PlayerDamage(1);
            Destroy(collision.gameObject);
        }
    }
}
