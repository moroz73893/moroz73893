using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

/// Shows and hides one overlay root. The extra screens are OUR OWN objects behind a
/// serialized reference rather than template panel indices: the only documented indices
/// are SPLASH, DEFAULT and TUTORIAL0..6, and repurposing an undocumented one is a guess.
public sealed class _0x0d4b5ddc : MonoBehaviour
{
    private void Start()
    {
        if (this._button != null)
        {
            this._button.onClick.AddListener(() => this._0x59f493e6());
        }

        if (this._closeButton != null)
        {
            this._closeButton.onClick.AddListener(() => this._0x845450a7());
        }

        if (this._root != null)
        {
            this._root.SetActive(false);
        }
    }

    public void _0x845450a7()
    {
        if (this._root != null)
        {
            this._root.SetActive(false);
        }
    }

    public void _0x403e9efb(float _0x95145190)
    {
        this._0x176e11df = _0x95145190;
    }

    private float _0x176e11df = 1f;
    [SerializeField]
    private Image _scrim;
    [SerializeField]
    private RectTransform _card;
    [SerializeField]
    private Button _closeButton;
    [SerializeField]
    private float _scrimAlpha = 0.68f;
    private void OnDestroy()
    {
        if (this._scrim != null)
        {
            DOTween.Kill(this._scrim);
        }

        if (this._card != null)
        {
            DOTween.Kill(this._card);
        }
    }

    public bool _0x3d171697
    {
        get
        {
            return this._root != null && this._root.activeSelf;
        }
    }

    [SerializeField]
    private GameObject _root;
    public void _0x59f493e6()
    {
        if (this._root == null)
        {
            return;
        }

        this._root.SetActive(true);
        if (this._scrim != null)
        {
            this._scrim.color = _0xa8208ec2.Fade(_0xa8208ec2.Ink, 0f);
            this._scrim.DOFade(this._scrimAlpha, 0.25f * this._0x176e11df).SetLink(this._scrim.gameObject);
        }

        if (this._card != null)
        {
            this._card.localScale = new Vector3(0.86f, 0.86f, 1f);
            this._card.DOScale(1f, 0.35f * this._0x176e11df).SetEase(Ease.OutBack).SetLink(this._card.gameObject);
        }
    }

    [SerializeField]
    private Button _button;
}