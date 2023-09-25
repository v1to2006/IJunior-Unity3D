using System.Collections;
using UnityEngine;

public class Alarm : MonoBehaviour
{
    private AudioSource _audioSource;

    private float _transition = 0.3f;

    private float _maxVolume = 1f;
    private float _minVolume = 0f;

    private Coroutine _increaseCoroutine;
    private Coroutine _decreaseCoroutine;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
        _audioSource.volume = 0f;
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.TryGetComponent<Thief>(out Thief thief))
        {
            _increaseCoroutine = StartCoroutine(IncreaseVolume());
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.TryGetComponent<Thief>(out Thief thief))
        {
            _decreaseCoroutine = StartCoroutine(DecreaseVolume());
        }
    }

    private IEnumerator IncreaseVolume()
    {
        if (_decreaseCoroutine != null)
            StopCoroutine(_decreaseCoroutine);

        if (_audioSource.volume == 0)
            _audioSource.Play();

        while (_audioSource.volume != 1f)
        {
            _audioSource.volume = Mathf.MoveTowards(_audioSource.volume, _maxVolume, _transition * Time.deltaTime);
            yield return null;
        }
    }

    private IEnumerator DecreaseVolume()
    {
        if (_increaseCoroutine != null)
            StopCoroutine(_increaseCoroutine);

        while (_audioSource.volume > 0f)
        {
            _audioSource.volume = Mathf.MoveTowards(_audioSource.volume, _minVolume, _transition * Time.deltaTime);
            yield return null;
        }

        _audioSource.Stop();
    }
}
