using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectableBehaviour : MonoBehaviour, ICollectableBehaviour // Implement ICollectableBehaviour
{
    [SerializeField]
    private float _healthAmount;

    public void OnCollected(GameObject player)
    {
        // Ensure that the player has a HealthController component before trying to add health
        var healthController = player.GetComponent<HealthController>();

        if (healthController != null)
        {
            healthController.AddHealth(_healthAmount);
        }
    }
}
