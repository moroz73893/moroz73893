using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// The menu: the purse, the island progress card, the three overlay gates and the one
/// piece of idle motion on the screen.
///
/// Only the crest breathes, it covers under 4 % of the frame, and Reduce Motion stops it.
/// A looping full-screen effect here would burn the capture's settle budget and send back
/// an empty album.
public sealed class _0x364c7582 : MonoBehaviour
{
    [SerializeField]
    private _0x5dd04d64 _purse;
    public void _0x78e7934a(bool _0x68225b74)
    {
        this._0xd6ed5bad = _0x68225b74 ? 0.5f : 1f;
        if (this._dailyGate != null)
        {
            this._dailyGate._0x403e9efb(this._0xd6ed5bad);
        }

        if (this._awardsGate != null)
        {
            this._awardsGate._0x403e9efb(this._0xd6ed5bad);
        }

        if (this._optionsGate != null)
        {
            this._optionsGate._0x403e9efb(this._0xd6ed5bad);
        }

        this._0x611c78fe();
    }

    private readonly _0x6e94ba0e _0xbaaaaa2a = new _0x6e94ba0e();
    [SerializeField]
    private _0x0d4b5ddc _dailyGate;
    private readonly _0x728dc014 _0x78795008 = new _0x728dc014();
    [SerializeField]
    private _0x12f4b64c _dailyBoard;
    [SerializeField]
    private _0x0d4b5ddc _awardsGate;
    private void Start()
    {
        this._0xbaaaaa2a._0xa0338909();
        this._0xd6ed5bad = this._0xbaaaaa2a._0x44faf748 ? 0.5f : 1f;
        if (this._meter != null)
        {
            this._meter._0x0f21715e();
        }

        if (this._dailyGate != null)
        {
            this._dailyGate._0x403e9efb(this._0xd6ed5bad);
        }

        if (this._awardsGate != null)
        {
            this._awardsGate._0x403e9efb(this._0xd6ed5bad);
        }

        if (this._optionsGate != null)
        {
            this._optionsGate._0x403e9efb(this._0xd6ed5bad);
        }

        if (this._dailyBoard != null)
        {
            this._dailyBoard._0x6f54e7fe(this, this._0xbaaaaa2a, this._0xd6ed5bad);
        }

        if (this._awardsBoard != null)
        {
            this._awardsBoard._0x19b01960(this._0xbaaaaa2a);
        }

        if (this._optionsBoard != null)
        {
            this._optionsBoard._0x9aea4ccb(this, this._0xbaaaaa2a);
        }

        _0x3b25dc9b.SetText(this._complianceLabel, _0x1f57d052._0xec36d88e(new byte[31] { 117, 97, 118, 118, 19, 112, 124, 122, 125, 96, 19, 124, 125, 127, 106, 19, 30, 19, 125, 124, 19, 97, 118, 114, 127, 19, 126, 124, 125, 118, 106 }, 51));
        if (this._complianceLabel != null)
        {
            this._complianceLabel.color = _0xa8208ec2.Sky;
        }

        this._0x8a7baaba();
        this._0x611c78fe();
        {
#if B_LOGS
            {
                Debug.Log($"[menu] island={this._0xbaaaaa2a._0xf6321898} meter={this._0xbaaaaa2a._0x0a5c913e} coins={this._0xbaaaaa2a._0x32e35cf7}");
            }
#endif
        }
    }

    private float _0xd6ed5bad = 1f;
    public void _0xf8ab3479()
    {
        this._0x8a7baaba();
        if (this._purse != null)
        {
            this._purse._0x441828ef(this._0xd6ed5bad);
        }

        if (this._dailyBoard != null)
        {
            this._dailyBoard._0x00a80fff();
        }

        if (this._awardsBoard != null)
        {
            this._awardsBoard._0x6e19c506();
        }
    }

    public void _0x37cc5d17()
    {
        if (this._purse != null)
        {
            this._purse._0x8c64b8a4(this._0xbaaaaa2a._0x32e35cf7, this._0xd6ed5bad);
        }

        if (this._awardsBoard != null)
        {
            this._awardsBoard._0x6e19c506();
        }
    }

    private void OnDestroy()
    {
        if (this._0xcf3b84ed != null)
        {
            this._0xcf3b84ed.Kill();
            this._0xcf3b84ed = null;
        }

        if (this._crest != null)
        {
            DOTween.Kill(this._crest);
        }
    }

    [SerializeField]
    private TMP_Text _complianceLabel;
    [SerializeField]
    private Image _crestImage;
    [SerializeField]
    private _0x412f7676 _meter;
    private Tween _0xcf3b84ed;
    [SerializeField]
    private _0xd2e66206 _awardsBoard;
    [SerializeField]
    private TMP_Text _playCaption;
    [SerializeField]
    private _0x0d4b5ddc _optionsGate;
    [SerializeField]
    private RectTransform _crest;
    public void _0x8a7baaba()
    {
        int _0x223b03a6 = this._0x78795008._0x196c0661(this._0xbaaaaa2a._0xf6321898);
        Color _0x3d964eef = _0xa8208ec2.FromChannels(this._0x78795008._0x50f1c2b6(_0x223b03a6), this._0x78795008._0x78e72dce(_0x223b03a6), this._0x78795008._0x7325a924(_0x223b03a6), 1f);
        if (this._purse != null)
        {
            this._purse._0xc5f18e7e(this._0xbaaaaa2a._0x32e35cf7);
            this._purse._0xc7a5228b(_0xa8208ec2.Sun);
        }

        _0x3b25dc9b.SetText(this._islandLabel, _0x1f57d052._0xec36d88e(new byte[7] { 168, 178, 173, 160, 175, 165, 193 }, 225) + (_0x223b03a6 + 1) + _0x1f57d052._0xec36d88e(new byte[4] { 182, 217, 208, 182 }, 150) + _0x728dc014.IslandCount + _0x1f57d052._0xec36d88e(new byte[3] { 76, 65, 76 }, 108) + this._0x78795008._0xce8cbce1(_0x223b03a6));
        if (this._islandLabel != null)
        {
            this._islandLabel.color = _0xa8208ec2.Sun;
        }

        if (this._meter != null)
        {
            this._meter._0x02f6584b(this._0xbaaaaa2a._0x0a5c913e, _0x728dc014.ChargesPerIsland, false);
            this._meter._0xa5496ccb(_0x3d964eef);
        }

        if (this._crestImage != null)
        {
            this._crestImage.preserveAspect = true;
        }

        // The PLAY button itself is a template prefab instance appended to the same
        // container; its own caption is blank, and this label - a later sibling, so drawn
        // on top - is what the player reads.
        if (this._playCaption != null)
        {
            this._playCaption.color = _0xa8208ec2.Cream;
            _0x3b25dc9b.SetText(this._playCaption, _0x1f57d052._0xec36d88e(new byte[4] { 91, 71, 74, 82 }, 11));
        }
    }

    [SerializeField]
    private TMP_Text _islandLabel;
    /// The single decorative loop of this screen, started here and killed in OnDestroy so
    /// it cannot survive into the game scene and animate a destroyed Image (rule C.56).
    private void _0x611c78fe()
    {
        if (this._0xcf3b84ed != null)
        {
            this._0xcf3b84ed.Kill();
            this._0xcf3b84ed = null;
        }

        if (this._crest == null)
        {
            return;
        }

        this._crest.localScale = Vector3.one;
        if (this._0xbaaaaa2a._0x44faf748)
        {
            return;
        }

        this._0xcf3b84ed = this._crest.DOScale(1.015f, 2.4f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine).SetLink(this._crest.gameObject);
    }

    [SerializeField]
    private _0x421b4b66 _optionsBoard;
}

internal static class _0x1f57d052
{
    internal static string _0xec36d88e(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}