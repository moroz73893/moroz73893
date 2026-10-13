using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0xa471e4fa : MonoBehaviour
{
    public TMP_Text ContentHeaderText;
    public static void HideAllPops()
    {
        _0xda9f334f.Instance._0x1a0587de();
    }

    public TMP_Text ContentAdditionalText;
    public float scaleDuration = 0.4f;
    public Ease ease = Ease.OutSine;
    private void Start()
    {
    // Content.SetActive(false);
    }

    private bool _0x7901cbcd => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0x5902d2c4();
    }

    public GameObject Content;
    public bool IsOnlyYScale;
    public TMP_Text ContentMainText;
    public Image ContentImage;
    public void _0x34f0d9ce()
    {
        if (this.Content.gameObject.activeSelf)
        {
            DOTween.Kill(this.Content.transform, true);
            if (this.IsOnlyYScale)
                this.Content.transform.DOScaleY(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
            else
                this.Content.transform.DOScale(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
        }
    }

    public bool IsScaledDownOnAwake = true;
    public void Show()
    {
        this.Content.SetActive(true);
        if ((DOTween.TweensByTarget(this.Content.transform)?.Count ?? 0) > 0)
            DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
        else
            this.Content.transform.DOScale(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
    }

    private void _0x5902d2c4()
    {
        DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(0f, 0.01f);
        else
            this.Content.transform.DOScale(0f, 0.01f);
        this.Content.SetActive(false);
    }
}