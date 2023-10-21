using DG.Tweening;
using UnityEngine;

public class MoveSphere : MonoBehaviour
{
    private void Start()
    {
        Move();
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
}
