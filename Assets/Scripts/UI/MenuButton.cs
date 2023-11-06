using TMPro;
using UnityEngine;

public class MenuButton : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _buttonText;

    private FontStyles _defaultfontStyle;
    private float _defaultFontSize;
    private Color _defaultFontColor;

    private int _pressCount = 0;

	private void Awake()
	{
        _defaultfontStyle = _buttonText.fontStyle;
		_defaultFontSize = _buttonText.fontSize;
        _defaultFontColor = _buttonText.color;
	}

	public void OnPointEnter()
    {
        FontStyles newfontStyle = FontStyles.Underline;
		float additionalFontSize = 3f;
        Color newColor = Color.red;

        _buttonText.fontStyle = newfontStyle;
        _buttonText.fontSize = _buttonText.fontSize + additionalFontSize;
        _buttonText.color = newColor;
    }

    public void OnPointExit()
    {
        _buttonText.fontStyle = _defaultfontStyle;
        _buttonText.fontSize = _defaultFontSize;
        _buttonText.color = _defaultFontColor;
	}

    public void OnPointClick()
    {
        float subtractiveFontSize = 3f;

		_buttonText.fontStyle = _defaultfontStyle;
		_buttonText.fontSize = subtractiveFontSize;
	}
}
