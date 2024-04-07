using UnityEngine;
using DG.Tweening;

public class MovingRotatingScalingCube : MonoBehaviour
{
    [SerializeField] private float _moveDistance = 3f;
    [SerializeField] private float _moveDuration = 1f;
    [SerializeField] private Vector3 _rotationAmount1 = new Vector3(0, 180, 0);
    [SerializeField] private Vector3 _rotationAmount2 = new Vector3(0, 360, 0);
    [SerializeField] private Vector3 _startScale = new Vector3(2f, 2f, 2f);
    [SerializeField] private Vector3 _endScale = new Vector3(1f, 1f, 1f);
    [SerializeField] private float _transitionDuration = 1f;
    [SerializeField] private float _intervalDuration = 1f;

    private void Start()
    {
        AnimateCube();
    }

    private void AnimateCube()
    {
        float startPositionY = transform.position.y; 

        DOTween.Sequence()
          .Append(transform.DOMoveY(_moveDistance, _moveDuration))
          .Join(transform.DORotate(_rotationAmount1, _transitionDuration))
          .Join(transform.DOScale(_startScale, _transitionDuration))
          .AppendInterval(_intervalDuration)
          .Append(transform.DOMoveY(startPositionY, _moveDuration))
          .Join(transform.DORotate(_rotationAmount2, _transitionDuration))
          .Join(transform.DOScale(_endScale, _transitionDuration))
          .SetLoops(-1);
    }
}