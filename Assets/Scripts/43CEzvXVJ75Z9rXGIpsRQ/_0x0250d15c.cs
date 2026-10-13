using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// The core loop: tap SPIN, the rules draw an outcome, the wheel turns to show it.
///
/// Rule C.5 is satisfied BY CONSTRUCTION, not by balancing. There is no timer in this
/// scene, no draining meter and no coroutine that ends a run; the balance changes only
/// inside HandleSpin, and the only way in is a Button.onClick. A run with zero taps is
/// therefore unbounded, which is a floor rather than an expected value.
public sealed class _0x0250d15c : MonoBehaviour
{
    public void _0xa46b1c0d()
    {
        this._0xb57ce54f._0x32e35cf7 = this._0x97505624._0xc262b495;
        this._0xb57ce54f._0x0a5c913e = this._0x97505624._0xe32a8242;
        this._0xb57ce54f._0xf6321898 = this._0x97505624._0x63540d22;
        this._0xb57ce54f._0x84b7030d();
    }

    private void OnDestroy()
    {
        this._0xc735086b();
        if (this._spinGlow != null)
        {
            DOTween.Kill(this._spinGlow);
        }

        if (this._banner != null)
        {
            DOTween.Kill(this._banner);
        }
    }

    [SerializeField]
    private RectTransform _wheelFrame;
    private Tween _0x2dd19437;
    [SerializeField]
    private TMP_Text _banner;
    [SerializeField]
    private _0xb3495d77 _hunt;
    private void Start()
    {
        this._0xb57ce54f._0xa0338909();
        this._0xfbdb64b8 = this._0xb57ce54f._0x44faf748 ? 0.5f : 1f;
        int _0x0255217b = this._0xb57ce54f._0x51fc6247 + 1;
        this._0xb57ce54f._0x51fc6247 = _0x0255217b;
        this._0x97505624._0x7b958dd0(this._0xb57ce54f._0xf6321898, _0x0255217b, this._0xb57ce54f._0x32e35cf7, this._0xb57ce54f._0x0a5c913e);
        {
#if B_LOGS
            {
                Debug.Log($"[session] island={this._0x97505624._0x63540d22} session={_0x0255217b} seed={this._0x97505624._0xc58e11b2} fallback={this._0x97505624._0x33be774d}");
            }
#endif
        }

        if (this._meter != null)
        {
            this._meter._0x0f21715e();
        }

        // The canvas rect is zero in Awake and autorotation changes it later, so the
        // wheel is measured here and again whenever the rect changes.
        this._0x7b08293c();
        if (this._faceBuilder != null)
        {
            this._faceBuilder._0xb7f2bfa3(this._0x97505624._0xd508ee74, this._0x78593788);
        }

        if (this._chips != null)
        {
            this._chips._0x02cfd735(this, this._0x97505624);
        }

        if (this._spinButton != null)
        {
            this._spinButton.onClick.AddListener(() => this._0x35d5e2eb());
        }

        if (this._hunt != null)
        {
            this._hunt._0x23137cee(this);
        }

        if (this._pops != null)
        {
            this._pops._0x00ce9d49(this);
        }

        _0x3b25dc9b.SetText(this._legend, _0x9ad84453._0x0dcdb6fe(new byte[25] { 30, 22, 21, 29, 121, 27, 24, 23, 29, 121, 121, 121, 33, 106, 121, 121, 121, 33, 108, 121, 121, 121, 33, 104, 105 }, 89));
        if (this._legend != null)
        {
            this._legend.color = _0xa8208ec2.Sun;
        }

        _0x3b25dc9b.SetText(this._hint, _0x9ad84453._0x0dcdb6fe(new byte[54] { 133, 144, 129, 241, 130, 129, 152, 159, 241, 133, 158, 241, 129, 157, 144, 136, 241, 241, 252, 241, 241, 129, 152, 146, 154, 241, 227, 241, 146, 153, 148, 130, 133, 130, 241, 158, 159, 241, 144, 241, 133, 131, 148, 144, 130, 132, 131, 148, 241, 134, 148, 149, 150, 148 }, 209));
        if (this._hint != null)
        {
            this._hint.color = _0xa8208ec2.Sky;
        }

        if (this._banner != null)
        {
            this._banner.color = _0xa8208ec2.Fade(_0xa8208ec2.Sun, 0f);
        }

        this._0x92fb1547();
        this._0x6b871954();
    }

    private float _0xfbdb64b8 = 1f;
    [SerializeField]
    private TMP_Text _islandLabel;
    public _0x6e94ba0e _0x38ac25cb
    {
        get
        {
            return this._0xb57ce54f;
        }
    }

    public void _0x92fb1547()
    {
        int _0x04b35ab0 = this._0x97505624._0x63540d22;
        Color _0x821d6a94 = _0xa8208ec2.FromChannels(this._0x3d1eba2c._0x50f1c2b6(_0x04b35ab0), this._0x3d1eba2c._0x78e72dce(_0x04b35ab0), this._0x3d1eba2c._0x7325a924(_0x04b35ab0), 1f);
        if (this._oceanTint != null)
        {
            this._oceanTint.color = _0xa8208ec2.Fade(_0x821d6a94, 0.18f);
        }

        if (this._rimImage != null)
        {
            this._rimImage.color = Color.Lerp(Color.white, _0x821d6a94, 0.35f);
        }

        if (this._meter != null)
        {
            this._meter._0x02f6584b(this._0x97505624._0xe32a8242, _0x728dc014.ChargesPerIsland, false);
            this._meter._0xa5496ccb(_0x821d6a94);
        }

        if (this._purse != null)
        {
            this._purse._0xc5f18e7e(this._0x97505624._0xc262b495);
            this._purse._0xc7a5228b(_0xa8208ec2.Sun);
        }

        _0x3b25dc9b.SetText(this._islandLabel, _0x9ad84453._0x0dcdb6fe(new byte[7] { 217, 195, 220, 209, 222, 212, 176 }, 144) + (_0x04b35ab0 + 1) + _0x9ad84453._0x0dcdb6fe(new byte[4] { 102, 9, 0, 102 }, 70) + _0x728dc014.IslandCount + _0x9ad84453._0x0dcdb6fe(new byte[3] { 124, 113, 124 }, 92) + this._0x3d1eba2c._0xce8cbce1(_0x04b35ab0));
        if (this._islandLabel != null)
        {
            this._islandLabel.color = _0xa8208ec2.Sun;
        }

        this._0x761c4fae();
    }

    [SerializeField]
    private Button _spinButton;
    private void _0x35d5e2eb()
    {
        this._0x4890c3f7(true);
    }

    [SerializeField]
    private _0xe5149b58 _pops;
    private void _0x6f1956a3(string _0x530478e7)
    {
        if (this._banner == null || this._bannerRect == null)
        {
            return;
        }

        float _0xdd7364cc = this._bannerRect.anchoredPosition.y;
        _0x3b25dc9b.SetText(this._banner, _0x530478e7);
        this._banner.color = _0xa8208ec2.Fade(_0xa8208ec2.Sun, 1f);
        Sequence _0x66a04c5a = DOTween.Sequence().SetLink(this._banner.gameObject);
        _0x66a04c5a.Append(this._bannerRect.DOPunchScale(new Vector3(0.12f, 0.12f, 0f), 0.45f * this._0xfbdb64b8, 6, 0.7f));
        _0x66a04c5a.AppendInterval(1.2f * this._0xfbdb64b8);
        _0x66a04c5a.Append(this._banner.DOFade(0.35f, 0.35f * this._0xfbdb64b8));
        this._bannerRect.anchoredPosition = new Vector2(this._bannerRect.anchoredPosition.x, _0xdd7364cc);
    }

    [SerializeField]
    private TMP_Text _legend;
    [SerializeField]
    private _0x7d37c993 _chips;
    [SerializeField]
    private _0x5dd04d64 _purse;
    [SerializeField]
    private Image _rimImage;
    private string _0xfc0d393c(_0xb927ebb5 _0x3f6e6aa1)
    {
        if (_0x3f6e6aa1.OpensHunt)
        {
            return _0x9ad84453._0x0dcdb6fe(new byte[14] { 55, 49, 38, 34, 48, 54, 49, 38, 67, 52, 38, 39, 36, 38 }, 99);
        }

        if (_0x3f6e6aa1.FreeSpin)
        {
            return _0x9ad84453._0x0dcdb6fe(new byte[9] { 125, 105, 126, 126, 27, 104, 107, 114, 117 }, 59);
        }

        if (_0x3f6e6aa1.Win > 0)
        {
            return _0x9ad84453._0x0dcdb6fe(new byte[1] { 39 }, 12) + _0x3b25dc9b.Grouped(_0x3f6e6aa1.Win) + _0x9ad84453._0x0dcdb6fe(new byte[6] { 37, 70, 74, 76, 75, 86 }, 5);
        }

        return _0x9ad84453._0x0dcdb6fe(new byte[20] { 133, 132, 235, 135, 158, 136, 128, 235, 230, 235, 152, 155, 130, 133, 235, 138, 140, 138, 130, 133 }, 203);
    }

    private void _0x761c4fae()
    {
        bool _0x4f71ab05 = this._0x97505624._0x35900af3();
        if (this._spinPlate != null)
        {
            this._spinPlate.color = _0x4f71ab05 ? _0xa8208ec2.Turquoise : _0xa8208ec2.Fade(_0xa8208ec2.Raised, 0.6f);
        }

        if (this._spinLabel != null)
        {
            this._spinLabel.color = _0xa8208ec2.Cream;
            _0x3b25dc9b.SetText(this._spinLabel, _0x4f71ab05 ? _0x9ad84453._0x0dcdb6fe(new byte[4] { 34, 33, 56, 63 }, 113) : _0x9ad84453._0x0dcdb6fe(new byte[16] { 194, 195, 216, 172, 201, 194, 195, 217, 203, 196, 172, 207, 195, 197, 194, 223 }, 140));
        }

        if (this._spinButton != null)
        {
            this._spinButton.interactable = _0x4f71ab05 && !this._0xf2702b40;
        }

        if (this._chips != null)
        {
            this._chips._0xa5ce9514(this._0x97505624._0x6cbf7f72, this._0x97505624._0x92246ec2);
            this._chips._0x59f4ad0d(!this._0xf2702b40);
        }
    }

    [SerializeField]
    private float _wheelWidthFraction = 0.86f;
    [SerializeField]
    private RectTransform[] _sparkles;
    [SerializeField]
    private RectTransform _wheelRoot;
    private void _0x6b871954()
    {
        this._0xc735086b();
        if (this._0xb57ce54f._0x44faf748)
        {
            return;
        }

        if (this._spinGlow != null)
        {
            this._spinGlow.color = _0xa8208ec2.Fade(_0xa8208ec2.Turquoise, 0.35f);
            this._0x2dd19437 = this._spinGlow.DOFade(0.6f, 1.4f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine).SetLink(this._spinGlow.gameObject);
        }

        if (this._sparkles == null || this._sparkles.Length == 0 || this._sparkles[0] == null)
        {
            return;
        }

        this._0xcc436312 = this._sparkles[0].DOScale(1.25f, 1.1f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine).SetLink(this._sparkles[0].gameObject);
    }

    [SerializeField]
    private _0xedd64b64 _faceBuilder;
    [SerializeField]
    private _0x412f7676 _meter;
    private void _0xc735086b()
    {
        if (this._0x2dd19437 != null)
        {
            this._0x2dd19437.Kill();
            this._0x2dd19437 = null;
        }

        if (this._0xcc436312 != null)
        {
            this._0xcc436312.Kill();
            this._0xcc436312 = null;
        }
    }

    private readonly _0x728dc014 _0x3d1eba2c = new _0x728dc014();
    private readonly _0xf5115610 _0x97505624 = new _0xf5115610();
    [SerializeField]
    private Image _oceanTint;
    /// Called back by the hunt when its two picks are spent.
    public void _0x1660dc7a()
    {
        this._0xf2702b40 = false;
        if (this._purse != null)
        {
            this._purse._0x8c64b8a4(this._0x97505624._0xc262b495, this._0xfbdb64b8);
        }

        if (this._meter != null)
        {
            this._meter._0x02f6584b(this._0x97505624._0xe32a8242, _0x728dc014.ChargesPerIsland, true);
        }

        this._0xa46b1c0d();
        this._0x74a3dc1c();
    }

    private void _0x487f641a(_0xb927ebb5 _0xba805af3)
    {
        _0x779dbee2 _0xaafcdeac = this._faceBuilder != null ? this._faceBuilder._0x29af5aa4(_0xba805af3.SectorIndex) : null;
        if (_0xaafcdeac != null)
        {
            _0xaafcdeac._0x95e804a4(this._0xfbdb64b8);
        }

        if (this._purse != null)
        {
            this._purse._0x8c64b8a4(this._0x97505624._0xc262b495, this._0xfbdb64b8);
        }

        if (this._meter != null)
        {
            this._meter._0x02f6584b(this._0x97505624._0xe32a8242, _0x728dc014.ChargesPerIsland, true);
        }

        this._0xb57ce54f._0x8c2a2200 = this._0xb57ce54f._0x8c2a2200 + 1;
        this._0xb57ce54f._0xe7ff2403(0, this._0xb57ce54f._0x009dc629(0) + 1);
        if (_0xba805af3.Win > this._0xb57ce54f._0x4f69350e)
        {
            this._0xb57ce54f._0x4f69350e = _0xba805af3.Win;
        }

        if (_0xba805af3.Label == _0x9ad84453._0x0dcdb6fe(new byte[3] { 203, 130, 131 }, 179))
        {
            this._0xb57ce54f._0x8a8d6ea6 = this._0xb57ce54f._0x8a8d6ea6 + 1;
        }

        if (_0xba805af3.Win > 0 && _0xba805af3.Bet > 0 && _0xba805af3.Win >= _0xba805af3.Bet * 3)
        {
            this._0xb57ce54f._0xe7ff2403(2, this._0xb57ce54f._0x009dc629(2) + 1);
        }

        this._0xa46b1c0d();
        this._0x6f1956a3(this._0xfc0d393c(_0xba805af3));
        this._0x761c4fae();
        if (_0xba805af3.OpensHunt && this._hunt != null)
        {
            DOVirtual.DelayedCall(2f * this._0xfbdb64b8, () => this._0xf4f729fe()).SetLink(this.gameObject);
            return;
        }

        if (_0xba805af3.FreeSpin)
        {
            DOVirtual.DelayedCall(0.8f * this._0xfbdb64b8, () => this._0x3de0cc00()).SetLink(this.gameObject);
            return;
        }

        DOVirtual.DelayedCall(0.2f * this._0xfbdb64b8, () => this._0x74a3dc1c()).SetLink(this.gameObject);
    }

    private Tween _0xcc436312;
    [SerializeField]
    private Image _spinPlate;
    public _0xf5115610 _0x46090d0c
    {
        get
        {
            return this._0x97505624;
        }
    }

    [SerializeField]
    private RectTransform _bannerRect;
    private void _0x74a3dc1c()
    {
        this._0xf2702b40 = false;
        if (this._hint != null)
        {
            this._hint.color = _0xa8208ec2.Sky;
        }

        if (this._0x97505624._0x036f113d())
        {
            this._0xa8637e4f();
            return;
        }

        if (this._0x97505624._0x4cb3b664() && this._pops != null)
        {
            this._pops._0x26acea2b();
            return;
        }

        this._0x761c4fae();
    }

    public float _0x258c40a9
    {
        get
        {
            return this._0xfbdb64b8;
        }
    }

    private void _0x4890c3f7(bool _0xc65180fb)
    {
        if (this._0xf2702b40 || !this._0x97505624._0x35900af3())
        {
            return;
        }

        this._0xf2702b40 = true;
        this._0x761c4fae();
        if (this._hint != null)
        {
            this._hint.color = _0xa8208ec2.Fade(_0xa8208ec2.Sky, 0.45f);
        }

        _0xb927ebb5 _0xd98e12d4 = this._0x97505624._0x1d878d68(_0xc65180fb);
        // The rules have already paid out; the purse shows the pre-payout figure while the
        // wheel turns and counts up when it stops, so the number lands with the result.
        if (this._purse != null)
        {
            this._purse._0xc5f18e7e(this._0x97505624._0xc262b495 - _0xd98e12d4.Win);
        }

        if (this._spinAnimator != null)
        {
            this._spinAnimator._0x8b9d11d1(_0xd98e12d4.StopAngle, this._0xfbdb64b8, () => this._0x487f641a(_0xd98e12d4));
        }
        else
        {
            this._0x487f641a(_0xd98e12d4);
        }
    }

    private void _0xf4f729fe()
    {
        if (this._hunt != null)
        {
            this._hunt._0xffa7537b();
        }
    }

    [SerializeField]
    private Image _spinGlow;
    [SerializeField]
    private TMP_Text _spinLabel;
    private float _0x78593788 = 1040f;
    public void _0x1c0df634()
    {
        this._0x97505624._0x162e7794();
        this._0xa46b1c0d();
        if (this._purse != null)
        {
            this._purse._0x8c64b8a4(this._0x97505624._0xc262b495, this._0xfbdb64b8);
        }

        this._0x761c4fae();
    }

    private bool _0xf2702b40;
    /// The WIN pop sails on: the ocean tint, the rim and the meter all repaint, so the
    /// button proves what it did rather than only changing a number.
    public void _0xee05c981()
    {
        this._0x92fb1547();
        if (this._meter != null)
        {
            this._meter._0x02f6584b(this._0x97505624._0xe32a8242, _0x728dc014.ChargesPerIsland, false);
        }

        this._0x74a3dc1c();
    }

    private void _0xa8637e4f()
    {
        int _0x7e5d6c91 = this._0x97505624._0x9a151612();
        bool _0x9f0ba0ec = this._0x97505624._0x7d19b24b();
        this._0xb57ce54f._0xb63d08f8 = this._0xb57ce54f._0xb63d08f8 + 1;
        this._0xa46b1c0d();
        this._0x92fb1547();
        if (this._pops != null)
        {
            this._pops._0x2b06bf69(_0x7e5d6c91, _0x9f0ba0ec);
        }
    }

    [SerializeField]
    private TMP_Text _hint;
    private void _0x7b08293c()
    {
        RectTransform _0xac9a12ba = this._wheelFrame != null ? this._wheelFrame : this._wheelRoot;
        if (_0xac9a12ba == null)
        {
            return;
        }

        RectTransform _0x4867a0e7 = _0xac9a12ba.parent as RectTransform;
        float width = _0x4867a0e7 != null && _0x4867a0e7.rect.width > 1f ? _0x4867a0e7.rect.width : 1242f;
        this._0x78593788 = width * this._wheelWidthFraction;
        _0xac9a12ba.sizeDelta = new Vector2(this._0x78593788, this._0x78593788);
        if (this._wheelRoot != null)
        {
            this._wheelRoot.sizeDelta = new Vector2(this._0x78593788, this._0x78593788);
        }

        if (this._rimImage != null)
        {
            RectTransform _0x3f76a0d1 = this._rimImage.transform as RectTransform;
            if (_0x3f76a0d1 != null)
            {
                _0x3f76a0d1.sizeDelta = new Vector2(this._0x78593788 * 1.115f, this._0x78593788 * 1.115f);
            }

            this._rimImage.preserveAspect = true;
        }
    }

    private readonly _0x6e94ba0e _0xb57ce54f = new _0x6e94ba0e();
    [SerializeField]
    private _0x7d7a0535 _spinAnimator;
    private void _0x3de0cc00()
    {
        this._0xf2702b40 = false;
        this._0x4890c3f7(false);
    }

    public void _0x3dc2d512(int _0xe0719949)
    {
        if (this._0xf2702b40)
        {
            return;
        }

        this._0x97505624._0xa24e1784(_0xe0719949);
        this._0x761c4fae();
    }
}

internal static class _0x9ad84453
{
    internal static string _0x0dcdb6fe(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}