using DG.Tweening;
using UnityEngine;

public class TweenColorAnimation : MonoBehaviour
{
    [SerializeField] private Material _material;

    private void Start()
    {
        PlayColorChangeAnimation();
    }

    private void PlayColorChangeAnimation()
    {
        Color startColor = Color.yellow;
        Color targetColor = Color.red;
        float transitionTime = 1.0f;
        int loopsCount = -1;
        LoopType loop = LoopType.Yoyo;
        Ease ease = Ease.Linear;

        _material.color = startColor;

        _material.DOColor(targetColor, transitionTime)
            .SetLoops(loopsCount, loop)
            .SetEase(ease);
    }
}
