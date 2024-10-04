using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteFlash : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;

    [SerializeField]
    private AudioClip _flashSound; 

    private AudioSource _audioSource;

    private void Awake()
    {
        _spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        _audioSource = gameObject.AddComponent<AudioSource>(); 
        _audioSource.clip = _flashSound; 
    }

    public IEnumerator FlashCoroutine(float flashDuration, Color flashColor, int numberOfFlashes)
    {
        Color startColor = _spriteRenderer.color;
        float elapsedFlashTime = 0;
        float elapsedFlashPercentage = 0;

        while (elapsedFlashTime < flashDuration)
        {
            elapsedFlashTime += Time.deltaTime;
            elapsedFlashPercentage = elapsedFlashTime / flashDuration;

            if (elapsedFlashPercentage > 1)
            {
                elapsedFlashPercentage = 1;
            }

            float pingPongPercentage = Mathf.PingPong(elapsedFlashPercentage * 2 * numberOfFlashes, 1);

            if (pingPongPercentage == 0) 
            {
                _audioSource.PlayOneShot(_flashSound); 
            }

            _spriteRenderer.color = Color.Lerp(startColor, flashColor, pingPongPercentage); 

            yield return null;
        }
    }
}