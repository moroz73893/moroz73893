using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// The splash: an abstract mark, a caption and the template loading bar in this game's
/// colours.
///
/// The emblem is a sun-wheel over a wave and carries NO letters - the app name appears
/// nowhere on screen, and a brand mark with the title baked into it would be the same
/// violation drawn instead of typed.
///
/// The intro is ONE SHOT. Nothing on this panel loops afterwards: the capture waits for
/// frames to stop changing, and a perpetual splash animation spends that whole budget.
public sealed class _0x942807f6 : MonoBehaviour
{
    [SerializeField]
    private TMP_Text _subCaption;
    [SerializeField]
    private CanvasGroup _emblemGroup;
    [SerializeField]
    private RectTransform _emblemRect;
    private void _0xc75095a0()
    {
        if (this._emblemGroup != null)
        {
            this._emblemGroup.alpha = 0f;
            this._emblemGroup.DOFade(1f, 0.8f).SetLink(this._emblemGroup.gameObject);
        }

        if (this._emblemRect != null)
        {
            this._emblemRect.localScale = new Vector3(0.9f, 0.9f, 1f);
            this._emblemRect.DOScale(1f, 0.8f).SetEase(Ease.OutBack).SetLink(this._emblemRect.gameObject);
        }
    }

    /// The slider lives in the template splash prefab, so it arrives by reference from
    /// the panel singleton rather than by a lookup on a name.
    public void _0x24987d4c(Slider _0xecd34848)
    {
        if (this._scrim != null)
        {
            this._scrim.color = _0xa8208ec2.Fade(new Color(0.043f, 0.141f, 0.251f, 1f), 0.55f);
        }

        if (this._emblem != null)
        {
            this._emblem.preserveAspect = true;
        }

        _0x3b25dc9b.SetText(this._caption, _0xab632059._0xc227162e(new byte[19] { 221, 196, 210, 218, 200, 177, 216, 194, 221, 208, 223, 213, 194, 177, 208, 198, 208, 216, 197 }, 145));
        if (this._caption != null)
        {
            this._caption.color = _0xa8208ec2.Cream;
        }

        _0x3b25dc9b.SetText(this._subCaption, _0xab632059._0xc227162e(new byte[7] { 79, 76, 66, 71, 74, 77, 68 }, 3));
        if (this._subCaption != null)
        {
            this._subCaption.color = _0xa8208ec2.Sky;
        }

        this._0xb2653e75(_0xecd34848);
        this._0xc75095a0();
    }

    private void OnDestroy()
    {
        if (this._emblemGroup != null)
        {
            DOTween.Kill(this._emblemGroup);
        }

        if (this._emblemRect != null)
        {
            DOTween.Kill(this._emblemRect);
        }
    }

    [SerializeField]
    private TMP_Text _caption;
    [SerializeField]
    private Image _emblem;
    [SerializeField]
    private Image _scrim;
    /// Fill takes the palette accent, the track takes a dark palette colour with REAL
    /// alpha instead of the near-transparent default, and the inner rects are re-stretched
    /// so the prefab inset cannot collapse the bar to nothing.
    private void _0xb2653e75(Slider _0x7e604990)
    {
        if (_0x7e604990 == null || _0x7e604990.fillRect == null)
        {
            return;
        }

        RectTransform _0x7d998517 = _0x7e604990.fillRect;
        Image _0xff4b62ab = _0x7d998517.GetComponent<Image>();
        if (_0xff4b62ab != null)
        {
            _0xff4b62ab.color = _0xa8208ec2.Turquoise;
        }

        // Slider.UpdateVisuals rewrites the fill anchors every frame; only the offsets
        // are ours to set.
        _0x7d998517.offsetMin = Vector2.zero;
        _0x7d998517.offsetMax = Vector2.zero;
        RectTransform _0x9378b4ed = _0x7d998517.parent as RectTransform;
        if (_0x9378b4ed == null)
        {
            return;
        }

        _0x9378b4ed.anchorMin = Vector2.zero;
        _0x9378b4ed.anchorMax = Vector2.one;
        _0x9378b4ed.offsetMin = new Vector2(8f, 8f);
        _0x9378b4ed.offsetMax = new Vector2(-8f, -8f);
        Image _0x6db41e2e = _0x9378b4ed.GetComponent<Image>();
        if (_0x6db41e2e != null)
        {
            _0x6db41e2e.color = _0xa8208ec2.Fade(new Color(0.039f, 0.141f, 0.251f, 1f), 0.85f);
        }
    }
}

internal static class _0xab632059
{
    internal static string _0xc227162e(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}