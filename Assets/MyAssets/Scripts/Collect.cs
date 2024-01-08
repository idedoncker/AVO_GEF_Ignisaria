using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    [SerializeField] int coinValue = 5;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject == gameObject)
        {
            return;
        }

        GameManager.instance.AddScore(coinValue);
        Destroy(gameObject);
    }
}
