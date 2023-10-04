using System.Collections;
using UnityEngine;

public class Alarm : MonoBehaviour
{
    private AudioSource _audioSource;
    private Coroutine _volumeCoroutine;
    private float _transition = 0.3f;

    private float _maxVolume = 1f;
    private float _minVolume = 0f;

    public void Play()
    {
        StopCurrentCoroutine();
        _volumeCoroutine = StartCoroutine(ChangeVolume(_maxVolume));
    }

    public void Stop()
    {
        StopCurrentCoroutine();
        _volumeCoroutine = StartCoroutine(ChangeVolume(_minVolume));
    }

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
        _audioSource.volume = _minVolume;
    }

    private void StopCurrentCoroutine()
    {
        if (_volumeCoroutine != null)
            StopCoroutine(_volumeCoroutine);
    }

    private IEnumerator ChangeVolume(float targetVolume)
    {
        if (_audioSource.volume == _minVolume)
            _audioSource.Play();

        while (_audioSource.volume != targetVolume)
        {
            _audioSource.volume = Mathf.MoveTowards(_audioSource.volume, targetVolume, _transition * Time.deltaTime);
            yield return null;
        }

        if (targetVolume == _minVolume)
            _audioSource.Stop();
    }
}