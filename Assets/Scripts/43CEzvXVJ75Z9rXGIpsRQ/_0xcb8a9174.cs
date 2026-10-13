using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// One award row. The medal gutter and the text column occupy two bands of x that never
/// overlap (rule C.25): TextAlignmentOptions.Left aligns inside the rect, it does not
/// move the rect, which is exactly how that defect hides from every static checker.
///
/// Card body is 1100 wide with 40 padding, so the usable half-width is 510.
///   gutterCentre = -398, gutterWidth = 110  -> gutter right edge = -343
///   textLeft     = -343 + 46 = -297         -> 46 px gap, well over the 24 px floor
///   textWidth    = 600                      -> right edge 303 <  =  5 1 0 ///Those  numbers  live  in  the  prefab ' s  RectTransforms ; this  component  only  fills  them. 
public sealed class _0xcb8a9174 : MonoBehaviour
{
    [SerializeField]
    private Image _barFill;
    [SerializeField]
    private Image _lockIcon;
    [SerializeField]
    private Image _medal;
    [SerializeField]
    private TMP_Text _name;
    [SerializeField]
    private float _barWidth = 600f;
    [SerializeField]
    private TMP_Text _progressLabel;
    [SerializeField]
    private RectTransform _barFillRect;
    [SerializeField]
    private Image _accent;
    public void _0xbbc8453a(string _0xa7b32b19, int _0xcde6ec74, int _0x578a3efb, bool _0x1b42c5ba)
    {
        _0x3b25dc9b.SetText(this._name, _0xa7b32b19);
        int _0x14a2862a = _0xcde6ec74 > _0x578a3efb ? _0x578a3efb : _0xcde6ec74;
        _0x3b25dc9b.SetText(this._progressLabel, _0x1b42c5ba ? _0x70b870df._0xb990ede8(new byte[8] { 71, 92, 94, 93, 81, 89, 87, 86 }, 18) : _0x14a2862a + _0x70b870df._0xb990ede8(new byte[3] { 241, 254, 241 }, 209) + _0x578a3efb);
        if (this._name != null)
        {
            this._name.color = _0x1b42c5ba ? _0xa8208ec2.Cream : _0xa8208ec2.Muted;
        }

        if (this._progressLabel != null)
        {
            this._progressLabel.color = _0x1b42c5ba ? _0xa8208ec2.Sun : _0xa8208ec2.Sky;
        }

        if (this._medal != null)
        {
            this._medal.gameObject.SetActive(_0x1b42c5ba);
        }

        if (this._lockIcon != null)
        {
            this._lockIcon.gameObject.SetActive(!_0x1b42c5ba);
            this._lockIcon.color = _0xa8208ec2.Fade(_0xa8208ec2.Muted, 0.5f);
        }

        if (this._accent != null)
        {
            this._accent.gameObject.SetActive(_0x1b42c5ba);
            this._accent.color = _0xa8208ec2.Sun;
        }

        if (this._barFill != null)
        {
            this._barFill.color = _0x1b42c5ba ? _0xa8208ec2.Sun : _0xa8208ec2.Green;
        }

        if (this._barFillRect != null)
        {
            float _0x4874ea18 = _0x578a3efb <= 0 ? 1f : (float)_0x14a2862a / _0x578a3efb;
            _0x4874ea18 = Mathf.Clamp01(_0x4874ea18);
            this._barFillRect.sizeDelta = new Vector2(this._barWidth * _0x4874ea18, this._barFillRect.sizeDelta.y);
        }
    }
}

internal static class _0x70b870df
{
    internal static string _0xb990ede8(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}