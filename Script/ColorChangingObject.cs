using UnityEngine;
using DG.Tweening;

public class ColorChangingObject : MonoBehaviour
{
    [SerializeField] private Color _targetColor = Color.blue;
    [SerializeField] private float _colorChangeDuration = 2f;

    private void Start()
    {
        ChangeColor();
    }

    private void ChangeColor()
    {
        DOTween.To(() => GetComponent<Renderer>().material.color, x => GetComponent<Renderer>().material.color = x, _targetColor, _colorChangeDuration)
            .SetLoops(-1, LoopType.Yoyo);
    }
}
