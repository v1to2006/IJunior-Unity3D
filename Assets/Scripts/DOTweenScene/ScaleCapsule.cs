using DG.Tweening;
using UnityEngine;

public class ScaleCapsule : MonoBehaviour
{
    private void Start()
    {
        Scale();
    }

    private void Scale()
    {
        Vector3 targetScale = new Vector3(2, 2, 2);
        float transitionTime = 2.0f;
        int loopsCount = -1;
        LoopType loop = LoopType.Yoyo;
        Ease ease = Ease.Linear;

        transform.DOScale(targetScale, transitionTime)
            .SetLoops(loopsCount, loop)
            .SetEase(ease);
    }
}
