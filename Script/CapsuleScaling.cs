using UnityEngine;
using DG.Tweening;

public class CapsuleScaling : MonoBehaviour
{
    [SerializeField] private Vector3 _scaleVector = new Vector3(2f, 2f, 2f);
    [SerializeField] private float _scaleDuration = 1f;

    private void Start()
    {
        ScaleCapsule();
    }

    private void ScaleCapsule()
    {
        transform.DOScale(_scaleVector, _scaleDuration).SetEase(Ease.InOutQuad)
            .SetLoops(-1, LoopType.Yoyo);
    }
}
