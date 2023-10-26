using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TweenTextAnimation : MonoBehaviour
{
    [SerializeField] private Text _text;

    private Sequence _textSequence;

    private void Start()
    {
        _textSequence = DOTween.Sequence();

        AddTextChange();
        AddTextAdd();
        AddTextScramble();

        _textSequence.SetLoops(-1, LoopType.Restart);
    }

    private void AddTextChange()
    {
        string toChange = "я ласковый мерзавец";
        float transitionTime = 2.0f;

        _textSequence.Append(_text.DOText(toChange, transitionTime));
    }

    private void AddTextAdd()
    {
        string toAdd = ", € сладкий на все сто";
        float transitionTime = 2.0f;

        _textSequence.Append(_text.DOText(toAdd, transitionTime).SetRelative());
    }

    private void AddTextScramble()
    {
        string toChange = "о-о-о.";
        float transitionTime = 2.0f;
        bool richTextEnabled = true;
        ScrambleMode scrambleMode = ScrambleMode.All;

        _textSequence.Append(_text.DOText(toChange, transitionTime, richTextEnabled, scrambleMode));
    }
}
