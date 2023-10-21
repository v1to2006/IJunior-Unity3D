using DG.Tweening;
using UnityEngine;

public class CapableCube : MonoBehaviour
{
    private void Start()
    {
        Move();
        Rotate();
        Scale();
    }

    private void Move()
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

    private void Rotate()
    {
        Vector3 targetRotation = new Vector3(360, 360, 360);
        float transitionTime = 2.0f;
        RotateMode rotateMode = RotateMode.FastBeyond360;
        int loopsCount = -1;
        LoopType loop = LoopType.Yoyo;
        Ease ease = Ease.Linear;

        transform.DOLocalRotate(targetRotation, transitionTime, rotateMode)
            .SetLoops(loopsCount, loop)
            .SetEase(ease);
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
