using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public int collisionDamage = 10;

    void Awake()
    {
        currentHealth = maxHealth;
    }

    void Start()
    {

    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public void GainHealth(int heal)
    {
        currentHealth += heal;
        if (currentHealth >= 100) 
        { 
            currentHealth = 100;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("Ouch!");
            TakeDamage(10);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("GreenBubble"))
        {
            Debug.Log("Heal!");
            GainHealth(10);
        }

        if (other.CompareTag("BlueBubble"))
        {
            Debug.Log("Blue bubble looted!");
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}