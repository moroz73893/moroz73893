using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// The two-metric strip this game puts inside every pop. The template ships generic
/// "Score:" and "Reward:" lines that mean nothing here; these carry metrics the game
/// actually keeps - SPINS and BEST WIN - and are filled at runtime, so no label is ever
/// shown next to an empty value.
public sealed class _0xa1cc5ca7 : MonoBehaviour
{
    private void _0x8393fea4(TMP_Text _0x5fc0e3e3, string _0x6053b4aa, Color _0x09f819ba)
    {
        if (_0x5fc0e3e3 == null)
        {
            return;
        }

        _0x5fc0e3e3.color = _0x09f819ba;
        _0x3b25dc9b.SetText(_0x5fc0e3e3, _0x6053b4aa);
    }

    [SerializeField]
    private TMP_Text _rightLabel;
    [SerializeField]
    private Image _icon;
    [SerializeField]
    private TMP_Text _leftLabel;
    [SerializeField]
    private TMP_Text _rightValue;
    [SerializeField]
    private Image _leftPlate;
    [SerializeField]
    private Image _rightPlate;
    public void _0xd5820692(Sprite _0x2116ac23, string _0xcc7763a3, string _0xf930d94a, string _0xb1b72c57, string _0x27ca2d67)
    {
        if (this._icon != null)
        {
            this._icon.sprite = _0x2116ac23;
            this._icon.preserveAspect = true;
            this._icon.gameObject.SetActive(_0x2116ac23 != null);
        }

        if (this._leftPlate != null)
        {
            this._leftPlate.color = _0xa8208ec2.Fade(_0xa8208ec2.Deep, 0.55f);
        }

        if (this._rightPlate != null)
        {
            this._rightPlate.color = _0xa8208ec2.Fade(_0xa8208ec2.Deep, 0.55f);
        }

        this._0x8393fea4(this._leftLabel, _0xcc7763a3, _0xa8208ec2.Sky);
        this._0x8393fea4(this._leftValue, _0xf930d94a, _0xa8208ec2.Cream);
        this._0x8393fea4(this._rightLabel, _0xb1b72c57, _0xa8208ec2.Sky);
        this._0x8393fea4(this._rightValue, _0x27ca2d67, _0xa8208ec2.Sun);
    }

    [SerializeField]
    private TMP_Text _leftValue;
}