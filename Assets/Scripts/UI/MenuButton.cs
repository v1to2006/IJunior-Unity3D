using TMPro;
using UnityEngine;

public class MenuButton : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _buttonText;

    private void OnSelect()
    {
        int additionalFontSize = 3;

        _buttonText.fontStyle = FontStyles.Underline;
        _buttonText.fontSize = _buttonText.fontSize + additionalFontSize;
    }
}
