using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// One painted wedge. The twelve wedges share ONE circular sprite drawn as a Filled
/// Radial360 Image, so an exact non-uniform angle costs no mesh and no SpriteRenderer -
/// which is also why nothing in this game can climb above the pop canvases.
public sealed class _0x779dbee2 : MonoBehaviour
{
    public void _0x2530af78(_0x0435f2a6 _0xae7098df, Sprite _0x0daef667, Sprite _0xcb8e7fa7, float _0x674e851a)
    {
        if (this._image != null)
        {
            this._image.sprite = _0x0daef667;
            this._image.type = Image.Type.Filled;
            this._image.fillMethod = Image.FillMethod.Radial360;
            this._image.fillOrigin = 2;
            this._image.fillClockwise = true;
            this._image.fillAmount = _0xae7098df.Angle / (float)_0x18daa9a8.FullCircle;
            this._0x6103ea00 = _0xa8208ec2.WedgeTint(_0xae7098df.TintIndex);
            this._image.color = this._0x6103ea00;
        }

        // The wedge rect is rotated to the sector start; the label sits on the bisector.
        RectTransform _0x55236c78 = this.transform as RectTransform;
        if (_0x55236c78 != null)
        {
            _0x55236c78.localRotation = Quaternion.Euler(0f, 0f, -_0xae7098df.StartAngle);
        }

        // The pivot sits at the wheel centre and only ROTATES; the label and the gem hang
        // off it at a radius, so rotating the pivot swings them along the bisector.
        if (this._labelPivot != null)
        {
            this._labelPivot.anchoredPosition = Vector2.zero;
            this._labelPivot.localRotation = Quaternion.Euler(0f, 0f, -_0xae7098df.Angle * 0.5f);
        }

        if (this._label != null)
        {
            this._label.rectTransform.anchoredPosition = new Vector2(0f, _0x674e851a);
        }

        if (this._gem != null)
        {
            this._gem.rectTransform.anchoredPosition = new Vector2(0f, _0x674e851a);
        }

        bool _0x2477eac6 = _0xae7098df.GemIndex >= 0 && _0xcb8e7fa7 != null;
        if (this._gem != null)
        {
            this._gem.gameObject.SetActive(_0x2477eac6);
            if (_0x2477eac6)
            {
                this._gem.sprite = _0xcb8e7fa7;
                this._gem.preserveAspect = true;
            }
        }

        if (this._label != null)
        {
            this._label.gameObject.SetActive(!_0x2477eac6);
            if (!_0x2477eac6)
            {
                this._label.color = _0xa8208ec2.WedgeLabel(_0xae7098df.TintIndex);
                _0x3b25dc9b.SetText(this._label, _0xae7098df.Label);
            }
        }
    }

    [SerializeField]
    private Image _image;
    [SerializeField]
    private RectTransform _labelPivot;
    [SerializeField]
    private TMP_Text _label;
    [SerializeField]
    private Image _gem;
    private void OnDestroy()
    {
        if (this._image != null)
        {
            DOTween.Kill(this._image);
        }
    }

    /// Two quick dips of the wedge fill, so the stop is readable in a still frame.
    public void _0x95e804a4(float _0xe93cdb04)
    {
        if (this._image == null)
        {
            return;
        }

        this._image.color = this._0x6103ea00;
        Sequence _0x7914ecb9 = DOTween.Sequence().SetLink(this.gameObject);
        for (int _0xea4e2c46 = 0; _0xea4e2c46 < 2; _0xea4e2c46++)
        {
            _0x7914ecb9.Append(this._image.DOFade(0.55f, 0.15f * _0xe93cdb04));
            _0x7914ecb9.Append(this._image.DOFade(1f, 0.15f * _0xe93cdb04));
        }
    }

    private Color _0x6103ea00;
}