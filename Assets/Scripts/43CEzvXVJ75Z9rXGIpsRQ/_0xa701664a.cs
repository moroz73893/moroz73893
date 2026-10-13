using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// One day of the seven-day streak track, in exactly three visual states. The claimed
/// badge is a SPRITE, never a glyph: the atlas this pipeline builds is ASCII 32..126, so
/// a tick character would render as tofu.
public sealed class _0xa701664a : MonoBehaviour
{
    [SerializeField]
    private TMP_Text _amountLabel;
    public const int StateClaimed = 2;
    [SerializeField]
    private Image _tickBadge;
    [SerializeField]
    private Image _coin;
    [SerializeField]
    private Image _plate;
    private Tween _0xc4fb11da;
    private void OnDestroy()
    {
        if (this._0xc4fb11da != null)
        {
            this._0xc4fb11da.Kill();
            this._0xc4fb11da = null;
        }

        DOTween.Kill(this.transform);
    }

    public const int StateToday = 1;
    [SerializeField]
    private TMP_Text _dayLabel;
    private void _0xfa9c14c1(Color _0xf46e71fe, Color _0x3ed0dbc0, float _0x164690c3, Color _0x4974d2bd)
    {
        if (this._plate != null)
        {
            this._plate.color = _0xf46e71fe;
        }

        if (this._border != null)
        {
            this._border.color = _0x3ed0dbc0;
        }

        if (this._coin != null)
        {
            this._coin.color = new Color(1f, 1f, 1f, _0x164690c3);
        }

        if (this._dayLabel != null)
        {
            this._dayLabel.color = _0x4974d2bd;
        }

        if (this._amountLabel != null)
        {
            this._amountLabel.color = _0x4974d2bd;
        }
    }

    public void _0x2e5eee9c(int _0x91272216, int amount)
    {
        _0x3b25dc9b.SetText(this._dayLabel, _0xb72b4b44._0xa42b9e8e(new byte[4] { 211, 214, 206, 183 }, 151) + _0x91272216);
        _0x3b25dc9b.SetText(this._amountLabel, _0xb72b4b44._0xa42b9e8e(new byte[1] { 61 }, 22) + _0x3b25dc9b.Grouped(amount));
    }

    [SerializeField]
    private Image _border;
    public const int StateLocked = 0;
    public void _0x8787a395(int _0xe63b4b79)
    {
        if (this._0xc4fb11da != null)
        {
            this._0xc4fb11da.Kill();
            this._0xc4fb11da = null;
        }

        this.transform.localScale = Vector3.one;
        if (this._tickBadge != null)
        {
            this._tickBadge.gameObject.SetActive(_0xe63b4b79 == StateClaimed);
        }

        if (_0xe63b4b79 == StateClaimed)
        {
            this._0xfa9c14c1(_0xa8208ec2.Green, _0xa8208ec2.Fade(_0xa8208ec2.Cream, 0.55f), 1f, _0xa8208ec2.Cream);
        }
        else if (_0xe63b4b79 == StateToday)
        {
            this._0xfa9c14c1(_0xa8208ec2.Sun, _0xa8208ec2.Coral, 1f, _0xa8208ec2.Cream);
            this.transform.localScale = new Vector3(1.06f, 1.06f, 1f);
            this._0xc4fb11da = this.transform.DOScale(1.12f, 0.8f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine).SetLink(this.gameObject);
        }
        else
        {
            this._0xfa9c14c1(_0xa8208ec2.Fade(_0xa8208ec2.Deep, 0.8f), _0xa8208ec2.Fade(_0xa8208ec2.Edge, 0.25f), 0.5f, _0xa8208ec2.Muted);
        }
    }
}

internal static class _0xb72b4b44
{
    internal static string _0xa42b9e8e(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}