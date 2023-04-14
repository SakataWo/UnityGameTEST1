using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBubble : MonoBehaviour
{
    private Collectable Bluebubble;

    private void Start()
    {
        Bluebubble = new Collectable("GreenBubble", 0, 5);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
