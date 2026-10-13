using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// One of the three stake chips. Selecting a chip changes TWO visible things - the chip
/// itself and the SPIN button's cost sub-label - so the tap confirms itself on screen
/// rather than only in a counter (rule C.7).
public sealed class _0x09033ffd : MonoBehaviour
{
    private void _0xc1e950c1()
    {
        if (this._0xa6767937 != null)
        {
            this._0xa6767937._0x9059cfd9(this._0x230063d6);
        }
    }

    [SerializeField]
    private Image _plate;
    private int _0x230063d6;
    public void _0xb7ff47cc(bool _0xafefd075)
    {
        if (this._button != null)
        {
            this._button.interactable = _0xafefd075;
        }
    }

    private _0x7d37c993 _0xa6767937;
    [SerializeField]
    private Image _border;
    public void _0x629ca05a(_0x7d37c993 _0xdd556782, int _0xee42c413, int amount)
    {
        this._0xa6767937 = _0xdd556782;
        this._0x230063d6 = _0xee42c413;
        _0x3b25dc9b.SetText(this._amount, _0x3b25dc9b.Grouped(amount));
        if (this._button != null)
        {
            this._button.onClick.AddListener(() => this._0xc1e950c1());
        }
    }

    [SerializeField]
    private TMP_Text _amount;
    [SerializeField]
    private Button _button;
    public void _0x26c2060f(bool _0x9f224fd3)
    {
        if (this._plate != null)
        {
            this._plate.color = _0x9f224fd3 ? _0xa8208ec2.Sun : _0xa8208ec2.Fade(_0xa8208ec2.Ocean, 0.5f);
        }

        if (this._border != null)
        {
            this._border.color = _0x9f224fd3 ? _0xa8208ec2.Coral : _0xa8208ec2.Fade(_0xa8208ec2.Edge, 0.35f);
        }

        if (this._amount != null)
        {
            this._amount.color = _0x9f224fd3 ? _0xa8208ec2.Cream : _0xa8208ec2.Sky;
        }

        this.transform.DOScale(_0x9f224fd3 ? 1.06f : 1f, 0.18f).SetEase(Ease.OutQuad).SetLink(this.gameObject);
    }
}