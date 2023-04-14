using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenBubble : MonoBehaviour
{
    private Collectable Greenbubble;

    private void Start()
    {
        Greenbubble = new Collectable("GreenBubble", 0, 5);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Health regained!");
            Destroy(gameObject);
        }
    }
}
