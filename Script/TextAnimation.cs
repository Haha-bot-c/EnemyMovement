using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class TextAnimation : MonoBehaviour
{
    [SerializeField] private Text _text; 
    [SerializeField] private float _duration = 1f;
    
    private readonly string[] _textVariations = { "Hello World!", "Dotween", "Animating Text", " is awesome!", "DOTween" };

    private void Start()
    {
        AnimateText();
    }

    private void AnimateText()
    {
        float scrambleDurationPerCharacter = 0.1f;

        DOTween.Sequence()
            .Append(_text.DOText("", _duration))
            .Append(_text.DOText(_textVariations[0], _duration)) 
            .AppendInterval(_duration)
            .Append(_text.DOText(_textVariations[0] + _textVariations[3], _duration)) 
            .AppendInterval(_duration)
            .Append(_text.DOText(_textVariations[1], _duration)) 
            .AppendInterval(_duration)
            .Append(_text.DOText(_textVariations[4], _textVariations[2].Length * scrambleDurationPerCharacter)) 
            .SetLoops(-1) 
            .Play();
    }
}

