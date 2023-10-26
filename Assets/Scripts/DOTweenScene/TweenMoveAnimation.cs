using DG.Tweening;
using UnityEngine;

public class TweenMoveAnimation : MonoBehaviour
{
    private void Start()
    {
        PlayMoveAnimation();
    }

    private void PlayMoveAnimation()
    {
        float targetXPosition = -5.0f;
        float transitionTime = 2.0f;
        int loopsCount = -1;
        LoopType loop = LoopType.Yoyo;
        Ease ease = Ease.Linear;

        transform.DOLocalMoveZ(targetXPosition, transitionTime)
            .SetLoops(loopsCount, loop)
            .SetEase(ease);
    }
}
