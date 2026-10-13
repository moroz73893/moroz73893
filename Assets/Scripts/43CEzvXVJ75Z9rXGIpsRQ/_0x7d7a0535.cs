using DG.Tweening;
using UnityEngine;

/// The spin itself: three full turns plus the angle the rules already decided, eased out
/// so the last degrees crawl. The pointer ticks once when the wheel settles.
public sealed class _0x7d7a0535 : MonoBehaviour
{
    public float _0x18afdd3f
    {
        get
        {
            return this._duration;
        }
    }

    [SerializeField]
    private float _duration = 3.2f;
    public void _0x683b4b30()
    {
        if (this._wheelRoot != null)
        {
            this._wheelRoot.localRotation = Quaternion.Euler(0f, 0f, this._0xece0e95d % 360f);
        }
    }

    [SerializeField]
    private RectTransform _pointer;
    private float _0xece0e95d;
    [SerializeField]
    private int _turns = 3;
    /// stopAngle is measured clockwise from the top, which is where the pointer sits, so
    /// the wheel has to rotate by its negative to bring that sector under the nose.
    public void _0x8b9d11d1(int _0x71b02d29, float _0x0fb2c2af, System.Action _0xd40a84b5)
    {
        if (this._wheelRoot == null)
        {
            if (_0xd40a84b5 != null)
            {
                _0xd40a84b5();
            }

            return;
        }

        float _0x9dbf21cc = -(this._turns * 360f) - _0x71b02d29;
        this._0xece0e95d = _0x9dbf21cc;
        Tween _0x1f5c6de2 = this._wheelRoot.DOLocalRotate(new Vector3(0f, 0f, _0x9dbf21cc), this._duration * _0x0fb2c2af, RotateMode.FastBeyond360).SetEase(Ease.OutQuint).SetLink(this._wheelRoot.gameObject);
        _0x1f5c6de2.OnComplete(() => this._0xa4a7be2c(_0x0fb2c2af, _0xd40a84b5));
    }

    [SerializeField]
    private RectTransform _wheelRoot;
    private void OnDestroy()
    {
        if (this._wheelRoot != null)
        {
            DOTween.Kill(this._wheelRoot);
        }

        if (this._pointer != null)
        {
            DOTween.Kill(this._pointer);
        }
    }

    private void _0xa4a7be2c(float _0x001dec19, System.Action _0xc8a6683a)
    {
        if (this._pointer != null)
        {
            this._pointer.DOPunchRotation(new Vector3(0f, 0f, 14f), 0.25f * _0x001dec19, 6, 0.6f).SetLink(this._pointer.gameObject);
        }

        this._0x683b4b30();
        if (_0xc8a6683a != null)
        {
            _0xc8a6683a();
        }
    }
}