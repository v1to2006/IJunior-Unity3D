using UnityEngine;

public class Thief : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.TryGetComponent<Alarm>(out Alarm alarm))
        {
            alarm.Play();
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.TryGetComponent<Alarm>(out Alarm alarm))
        {
            alarm.Stop();
        }
    }
}
