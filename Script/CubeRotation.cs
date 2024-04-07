using UnityEngine;
using DG.Tweening;

public class CubeRotation : MonoBehaviour
{
    [SerializeField] private Vector3 _rotationAmount = new Vector3(0, 360, 0);
    [SerializeField] private float _rotationDuration = 2f;

    private void Start()
    {
        RotateCube();
    }

    private void RotateCube()
    {
        transform.DORotate(_rotationAmount, _rotationDuration, RotateMode.LocalAxisAdd)
            .SetEase(Ease.Linear)
            .SetLoops(-1, LoopType.Restart);
    }
}
