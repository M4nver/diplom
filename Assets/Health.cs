using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{

    public int health;
    public int maxHealth;
    public Text _text;

    public GameObject _obj;

    private void Start() {
        _text.text = health.ToString();
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        _text.text = health.ToString();

        if (health <= 0)
        {
            Destroy(gameObject);
            _obj.SetActive(true);
            health = 0;
            _text.text = health.ToString();
        }
    }

    public void SetHealth(int bonusHealth)
    {
        health += bonusHealth;
        _text.text = health.ToString();
        if (health > maxHealth)
        {
            health = maxHealth;
            _text.text = health.ToString();
        }
    }
}
