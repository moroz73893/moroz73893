using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x8ae4c95e : MonoBehaviour
{
    public float ScaleDuration = 0.4f;
    private bool _0xff6777b4 => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    public void _0x8dda9d83()
    {
        this._0xa5c5ad3e();
        this.Content.SetActive(true);
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.localScale = Vector3.one;
        _0x6ae8a66c.Instance._0x00bca0cc(_0x6ae8a66c.Instance.CurrentPanelIndex);
    }

    private void _0x7dcf5bdd()
    {
        if (this.OuterBackground != null)
        {
            Image _0x7d2de8ce = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x7d2de8ce, true);
            _0x7d2de8ce.DOFade(1f, this.ScaleDuration / 2f);
        }
    }

    public GameObject OuterBackground;
    public GameObject Content;
    private void _0x59a166d1()
    {
        if (this.OuterBackground != null)
        {
            Image _0xc59a2978 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xc59a2978, true);
            _0xc59a2978.DOFade(0f, 0.01f);
        }

        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, 0.01f);
    }

    private void _0xa5c5ad3e()
    {
        if (this.OuterBackground != null)
        {
            Image _0xdef1a0b7 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xdef1a0b7, true);
            _0xdef1a0b7.DOFade(1f, 0f);
        }
    }

    public TMP_Text MainText;
    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.OuterBackground != null)
            this.OuterBackground.gameObject.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0x59a166d1();
    }

    private void _0xde0cfc76()
    {
        if (this.OuterBackground != null)
        {
            Image _0x58681099 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x58681099, true);
            _0x58681099.DOFade(0f, this.ScaleDuration);
        }
    }

    public void _0x7a2d6ca8()
    {
        this._0xde0cfc76();
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
        {
            this.Content.SetActive(false);
        });
    }

    public Ease Ease = Ease.OutSine;
    public bool IsScaledDownOnAwake = true;
    public void Show()
    {
        this._0x7dcf5bdd();
        if (this.Content != null)
        {
            DOTween.Kill(this.Content.transform, true);
            this.Content.SetActive(true);
            this.Content.transform.DOScale(1f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
            {
                _0x6ae8a66c.Instance._0x00bca0cc(_0x6ae8a66c.Instance.CurrentPanelIndex);
            });
        }
    }

    public TMP_Text HeaderText;
}