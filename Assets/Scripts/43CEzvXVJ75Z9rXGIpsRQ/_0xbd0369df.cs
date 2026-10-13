using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// One chest of the Treasure Hunt board. Taps are plain UGUI; the reveal swaps the chest
/// sprite and fades in the prize, so two consecutive frames of the album differ.
public sealed class _0xbd0369df : MonoBehaviour
{
    private void _0xfd0f833a(Sprite _0x15195ee6, string amount, Color _0xa14fee8f, float _0x1c0e67f8)
    {
        if (this._chestImage != null)
        {
            this._chestImage.sprite = this._openSprite;
            this._chestImage.preserveAspect = true;
        }

        if (this._contentImage != null)
        {
            this._contentImage.sprite = _0x15195ee6;
            this._contentImage.preserveAspect = true;
            this._contentImage.gameObject.SetActive(_0x15195ee6 != null);
            this._contentImage.color = new Color(1f, 1f, 1f, 0f);
            this._contentImage.DOFade(1f, 0.25f * _0x1c0e67f8).SetLink(this._contentImage.gameObject);
        }

        if (this._amountLabel != null)
        {
            this._amountLabel.color = _0xa14fee8f;
            _0x3b25dc9b.SetText(this._amountLabel, amount);
        }
    }

    private _0xb3495d77 _0xd988c995;
    public void _0x78a644e9()
    {
        if (this._0x2861c71f || this._group == null)
        {
            return;
        }

        this._group.DOFade(0.45f, 0.25f).SetLink(this._group.gameObject);
    }

    [SerializeField]
    private Button _button;
    /// Reveals this chest. The lid punch runs first, the sprite swaps mid-punch and the
    /// prize fades in after it, so the change is legible rather than instant.
    public void _0x4bfd42b7(Sprite _0xd1d24785, string amount, Color _0x7f41dea2, float _0xa4b51eee)
    {
        this._0x2861c71f = true;
        if (this._button != null)
        {
            this._button.interactable = false;
        }

        if (this._plate != null)
        {
            this._plate.color = _0xa8208ec2.Fade(_0xa8208ec2.Sun, 0.22f);
        }

        Sequence _0x153a8cfe = DOTween.Sequence().SetLink(this.gameObject);
        _0x153a8cfe.Append(this.transform.DOPunchScale(new Vector3(0.18f, 0.18f, 0f), 0.35f * _0xa4b51eee, 6, 0.6f));
        _0x153a8cfe.InsertCallback(0.18f * _0xa4b51eee, () => this._0xfd0f833a(_0xd1d24785, amount, _0x7f41dea2, _0xa4b51eee));
    }

    private void _0xc23e4f14()
    {
        if (this._0x2861c71f || this._0xd988c995 == null)
        {
            return;
        }

        this._0xd988c995._0x221f69c5(this._0xbb656cb1, this);
    }

    public void _0x4c267718()
    {
        this._0x2861c71f = false;
        if (this._chestImage != null)
        {
            this._chestImage.sprite = this._closedSprite;
            this._chestImage.preserveAspect = true;
        }

        if (this._contentImage != null)
        {
            this._contentImage.gameObject.SetActive(false);
            this._contentImage.color = new Color(1f, 1f, 1f, 0f);
        }

        if (this._amountLabel != null)
        {
            _0x3b25dc9b.SetText(this._amountLabel, string.Empty);
        }

        if (this._group != null)
        {
            this._group.alpha = 1f;
        }

        if (this._plate != null)
        {
            this._plate.color = _0xa8208ec2.Fade(_0xa8208ec2.Surface, 0.9f);
        }

        if (this._button != null)
        {
            this._button.interactable = true;
        }

        this.transform.localScale = Vector3.one;
    }

    [SerializeField]
    private CanvasGroup _group;
    [SerializeField]
    private Sprite _openSprite;
    public bool _0x9a590764
    {
        get
        {
            return this._0x2861c71f;
        }
    }

    public void _0x62372e49(bool _0xa6392bc8)
    {
        if (this._button != null)
        {
            this._button.interactable = _0xa6392bc8 && !this._0x2861c71f;
        }
    }

    [SerializeField]
    private TMP_Text _amountLabel;
    [SerializeField]
    private Image _chestImage;
    public void _0x61a85e36(_0xb3495d77 _0x204dae3d, int _0xd2d5d8c2)
    {
        this._0xd988c995 = _0x204dae3d;
        this._0xbb656cb1 = _0xd2d5d8c2;
        if (this._button != null)
        {
            this._button.onClick.AddListener(() => this._0xc23e4f14());
        }
    }

    private void OnDestroy()
    {
        DOTween.Kill(this.transform);
    }

    private int _0xbb656cb1;
    [SerializeField]
    private Sprite _closedSprite;
    [SerializeField]
    private Image _contentImage;
    private bool _0x2861c71f;
    [SerializeField]
    private Image _plate;
}