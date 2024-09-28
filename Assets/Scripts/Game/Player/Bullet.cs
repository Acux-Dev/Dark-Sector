using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Bullet : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<EnemyMovement>())
        {
            HealthController healthController = collision.GetComponent<HealthController>();
            healthController.TakeDamage(10);
            Destroy(gameObject);
        }
        if (collision.GetComponent<TilemapCollider2D>())
        {
            Destroy(gameObject);
        }
    }
}
