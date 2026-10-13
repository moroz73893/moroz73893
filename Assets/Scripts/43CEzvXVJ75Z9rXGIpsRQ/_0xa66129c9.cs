using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

/// One charge pip of the Fortune Meter. The meter only ever goes up, which is half of
/// why a run with no taps is unbounded (rule C.5).
public sealed class _0xa66129c9 : MonoBehaviour
{
    public void _0x1a96900a(bool _0xec0659bd, bool _0xa0dbc4b8)
    {
        bool _0x296e7c17 = this._0x17964b76;
        this._0x17964b76 = _0xec0659bd;
        if (this._fill != null)
        {
            this._fill.color = _0xec0659bd ? _0xa8208ec2.Turquoise : _0xa8208ec2.Fade(_0xa8208ec2.Deep, 0.75f);
        }

        if (this._frame != null)
        {
            this._frame.color = _0xec0659bd ? _0xa8208ec2.Fade(_0xa8208ec2.Cream, 0.55f) : _0xa8208ec2.Fade(_0xa8208ec2.Edge, 0.4f);
        }

        if (_0xa0dbc4b8 && _0xec0659bd && !_0x296e7c17)
        {
            this.transform.localScale = new Vector3(0.2f, 0.2f, 1f);
            this.transform.DOScale(1f, 0.3f).SetEase(Ease.OutBack).SetLink(this.gameObject);
        }
    }

    private bool _0x17964b76;
    [SerializeField]
    private Image _frame;
    public void _0x53b4bb40(Color _0xb195222b)
    {
        if (this._0x17964b76 && this._fill != null)
        {
            this._fill.color = _0xb195222b;
        }
    }

    [SerializeField]
    private Image _fill;
}