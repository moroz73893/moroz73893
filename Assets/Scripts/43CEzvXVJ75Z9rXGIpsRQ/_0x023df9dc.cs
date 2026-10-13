using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

/// A sliding pill switch. The knob really slides and the track really changes colour, so
/// the setting proves itself in the same frame it is tapped (rule C.7).
public sealed class _0x023df9dc : MonoBehaviour
{
    private int _0x00700f22;
    private _0x421b4b66 _0xf299d39b;
    [SerializeField]
    private float _knobTravel = 54f;
    public void _0xf031ea60(_0x421b4b66 _0x1ca36a1c, int _0x8e8c06b8, bool _0x43179c8d)
    {
        this._0xf299d39b = _0x1ca36a1c;
        this._0x00700f22 = _0x8e8c06b8;
        this._0x7bf7dac4(_0x43179c8d, false);
        if (this._button != null)
        {
            this._button.onClick.AddListener(() => this._0xe6554378());
        }
    }

    private bool _0x3db67878;
    public void _0x7bf7dac4(bool _0x9bc59f5f, bool _0xb1fcbc53)
    {
        this._0x3db67878 = _0x9bc59f5f;
        if (this._track != null)
        {
            this._track.color = _0x9bc59f5f ? _0xa8208ec2.Turquoise : _0xa8208ec2.Fade(_0xa8208ec2.Raised, 0.6f);
        }

        if (this._knob == null)
        {
            return;
        }

        float _0xf563281f = _0x9bc59f5f ? this._knobTravel : -this._knobTravel;
        if (_0xb1fcbc53)
        {
            this._knob.DOAnchorPosX(_0xf563281f, 0.18f).SetEase(Ease.OutCubic).SetLink(this._knob.gameObject);
        }
        else
        {
            this._knob.anchoredPosition = new Vector2(_0xf563281f, this._knob.anchoredPosition.y);
        }
    }

    [SerializeField]
    private RectTransform _knob;
    public bool _0xa29967e2
    {
        get
        {
            return this._0x3db67878;
        }
    }

    private void _0xe6554378()
    {
        this._0x7bf7dac4(!this._0x3db67878, true);
        if (this._0xf299d39b != null)
        {
            this._0xf299d39b._0x4e2a380f(this._0x00700f22, this._0x3db67878);
        }
    }

    [SerializeField]
    private Button _button;
    [SerializeField]
    private Image _track;
}