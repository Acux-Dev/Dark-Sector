using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerAwarenessController : MonoBehaviour
{
    public bool AwareOfPlayer { get; private set; }

    public Vector2 DirectionToPlayer { get; private set; } 

    [SerializeField]
    private float _PlayerAwarenessDistance;

    private Transform _Player;

    private void Awake()
    {
        _Player = FindObjectOfType<PlayerMovement>().transform;
    }

    void Update()
    {
        Vector2 enemyToPlayerVector = _Player.position - transform.position;
        DirectionToPlayer = enemyToPlayerVector.normalized;

        if (enemyToPlayerVector.magnitude <= _PlayerAwarenessDistance)
        {
            AwareOfPlayer = true;
        }
        else
        {
            AwareOfPlayer = false;
        }
    }
}