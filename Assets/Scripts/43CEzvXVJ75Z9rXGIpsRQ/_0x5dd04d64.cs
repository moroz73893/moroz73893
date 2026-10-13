using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// The coin pill. Counting up is a numeric tween plus a punch on the pill, so a win is
/// visible in a still frame and not only in the final number.
public sealed class _0x5dd04d64 : MonoBehaviour
{
    private void OnDestroy()
    {
        DOTween.Kill(this.gameObject);
        if (this._pill != null)
        {
            DOTween.Kill(this._pill);
        }
    }

    private int _0x998beb4d;
    [SerializeField]
    private Image _icon;
    [SerializeField]
    private RectTransform _pill;
    [SerializeField]
    private TMP_Text _label;
    public void _0x8c64b8a4(int _0x9a49915c, float _0x06bb2899)
    {
        int _0x40026875 = this._0x998beb4d;
        this._0x998beb4d = _0x9a49915c;
        DOTween.To(() => _0x40026875, _0xd3221b2e => this._0xe8170a05(_0xd3221b2e), _0x9a49915c, 0.6f * _0x06bb2899).SetLink(this.gameObject);
        this._0x441828ef(_0x06bb2899);
    }

    public void _0x441828ef(float _0x00ea87c9)
    {
        if (this._pill == null)
        {
            return;
        }

        this._pill.DOPunchScale(new Vector3(0.18f, 0.18f, 0f), 0.45f * _0x00ea87c9, 6, 0.7f).SetLink(this._pill.gameObject);
    }

    public void _0xc5f18e7e(int _0x7b236994)
    {
        this._0x998beb4d = _0x7b236994;
        _0x3b25dc9b.SetText(this._label, _0x3b25dc9b.Grouped(_0x7b236994));
    }

    private void _0xe8170a05(int _0xcbc05670)
    {
        _0x3b25dc9b.SetText(this._label, _0x3b25dc9b.Grouped(_0xcbc05670));
    }

    public void _0xc7a5228b(Color _0xc84f9c4d)
    {
        if (this._icon != null)
        {
            this._icon.color = Color.white;
        }

        if (this._label != null)
        {
            this._label.color = _0xc84f9c4d;
        }
    }
}