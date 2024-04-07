using UnityEngine;
using DG.Tweening;

public class SphereAnimation : MonoBehaviour
{
    [SerializeField] private float _moveDistance = 5f;
    [SerializeField] private float _moveDuration = 2f;

    private void Start()
    {
        AnimateSphere();
    }

    private void AnimateSphere()
    {
        float startPositionY = transform.position.y;

        DOTween.Sequence()
            .Append(transform.DOMoveZ(_moveDistance, _moveDuration))
            .Append(transform.DOMoveZ(-_moveDistance, _moveDuration))
            .Join(transform.DOMoveZ(startPositionY, _moveDuration))
            .SetLoops(-1)
            .SetEase(Ease.Linear);
    }
}