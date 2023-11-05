using DG.Tweening;
using UnityEngine;

public class TweenScaleAnimation : MonoBehaviour
{
    private void Start()
    {
        PlayScaleAnimation();
    }

    private void PlayScaleAnimation()
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
