using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyAttack : MonoBehaviour
{
    [SerializeField]
    private float _damageAmount;

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.GetComponent<PlayerMovement>() != null)
        {

            var healthController = collision.gameObject.GetComponent<HealthController>();

   
            if (healthController != null)
            {
 
                healthController.TakeDamage(_damageAmount);
            }
            else
            {
                Debug.LogError("El objeto con el que colisionó no tiene un componente HealthController.");
            }
        }
    }
}