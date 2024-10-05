using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyDeadParticles : MonoBehaviour
{

    [SerializeField]
    private ParticleSystem _bloodParticles;

    public void DeadParticles()
    {
        Instantiate(_bloodParticles, transform.position, Quaternion.identity);

    }
}
