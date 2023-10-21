using DG.Tweening;
using UnityEngine;

public class RotateCube : MonoBehaviour
{
    private void Start()
    {
        Rotate();
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
}
