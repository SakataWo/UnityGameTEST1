using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public float wanderSpeed = 5.0f; 
    public float wanderRange = 10.0f; 
    public float detectionRange = 30.0f; 
    public float chaseSpeed = 20.0f; 
    public Transform player; 
    private Vector3 wanderAim; 
    private bool isChasing;


    void Start()
    {
        currentHealth = maxHealth;
        wanderAim = GetNewWanderAim();
    }

    void Update()
    {
        if (!isChasing)
        {
            transform.position = Vector3.MoveTowards(transform.position, wanderAim, wanderSpeed * Time.deltaTime);

            if (transform.position == wanderAim)
            {
                wanderAim = GetNewWanderAim();
            }

            if (Vector3.Distance(transform.position, player.position) <= detectionRange)
            {
                isChasing = true;
                Debug.Log("I found you!");
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, player.position, chaseSpeed * Time.deltaTime);

            if (Vector3.Distance(transform.position, player.position) > detectionRange)
            {
                isChasing = false;
            }
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }

    private Vector3 GetNewWanderAim()
    {
        return new Vector3(Random.Range(-wanderRange, wanderRange), 0, Random.Range(-wanderRange, wanderRange));
    }
}
