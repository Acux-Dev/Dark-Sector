using System.Collections.Generic;
using UnityEngine;

public class EnemyCollectableDrop : MonoBehaviour
{
    [SerializeField]
    private float _chanceOfCollectableDrop;

    [SerializeField]
    private AudioClip _dropSound;  
    private AudioSource _audioSource;  

    private CollectableSpawner _collectableSpawner;

    private void Awake()
    {
        _collectableSpawner = FindObjectOfType<CollectableSpawner>();
        _audioSource = GetComponent<AudioSource>();  
    }

    public void RandomlyDropCollectable()
    {
        float random = Random.Range(0f, 1f);

       
        if (_chanceOfCollectableDrop >= random)
        {
            
            _collectableSpawner.SpawnCollectable(transform.position);

            if (_audioSource != null && _dropSound != null)
            {
                _audioSource.PlayOneShot(_dropSound);
            }
        }
    }
}