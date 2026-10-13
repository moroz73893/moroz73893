using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// Haptics, Reduce Motion and a guarded progress reset.
///
/// There is deliberately NO sound row, NO music row and NO volume slider: this game ships
/// without audio, so such a control would change nothing when tapped, and a dead toggle is
/// worse than a missing one (rule C.20). The row it would have occupied carries Reduce
/// Motion instead, which really does change what the next frame looks like.
public sealed class _0x421b4b66 : MonoBehaviour
{
    [SerializeField]
    private _0x023df9dc _togglePrefab;
    [SerializeField]
    private Button _resetButton;
    private _0x364c7582 _0xc9ec1221;
    [SerializeField]
    private GameObject _confirmRoot;
    [SerializeField]
    private RectTransform _hapticsHost;
    private void _0x1519941d()
    {
        if (this._0xf5c598c9 != null)
        {
            this._0xf5c598c9._0xece5d710();
        }

        if (this._0x656d6dd6 != null)
        {
            this._0x656d6dd6._0x7bf7dac4(this._0xf5c598c9._0xe276b82c, false);
        }

        if (this._0x732703eb != null)
        {
            this._0x732703eb._0x7bf7dac4(this._0xf5c598c9._0x44faf748, false);
        }

        this._0xcb03b5d0();
        if (this._0xc9ec1221 != null)
        {
            this._0xc9ec1221._0xf8ab3479();
        }
    }

    private void _0x0f8c9f15()
    {
        if (this._confirmRoot == null)
        {
            return;
        }

        this._confirmRoot.SetActive(true);
        this._confirmRoot.transform.localScale = new Vector3(0.86f, 0.86f, 1f);
        this._confirmRoot.transform.DOScale(1f, 0.3f).SetEase(Ease.OutBack).SetLink(this._confirmRoot);
    }

    public void _0x9aea4ccb(_0x364c7582 _0x43bc71c9, _0x6e94ba0e _0x58955f0a)
    {
        this._0xc9ec1221 = _0x43bc71c9;
        this._0xf5c598c9 = _0x58955f0a;
        this._0x656d6dd6 = this._0x143d4fc3(this._hapticsHost);
        if (this._0x656d6dd6 != null)
        {
            this._0x656d6dd6._0xf031ea60(this, ChannelHaptics, _0x58955f0a._0xe276b82c);
        }

        this._0x732703eb = this._0x143d4fc3(this._motionHost);
        if (this._0x732703eb != null)
        {
            this._0x732703eb._0xf031ea60(this, ChannelReduceMotion, _0x58955f0a._0x44faf748);
        }

        if (this._resetButton != null)
        {
            this._resetButton.onClick.AddListener(() => this._0x0f8c9f15());
        }

        if (this._confirmYes != null)
        {
            this._confirmYes.onClick.AddListener(() => this._0x1519941d());
        }

        if (this._confirmNo != null)
        {
            this._confirmNo.onClick.AddListener(() => this._0xcb03b5d0());
        }

        _0x3b25dc9b.SetText(this._confirmTitle, _0x510b47cb._0xc593011b(new byte[19] { 43, 60, 42, 60, 45, 89, 56, 53, 53, 89, 41, 43, 54, 62, 43, 60, 42, 42, 70 }, 121));
        _0x3b25dc9b.SetText(this._confirmBody, _0x510b47cb._0xc593011b(new byte[44] { 25, 21, 19, 20, 9, 118, 122, 19, 9, 22, 27, 20, 30, 9, 122, 27, 20, 30, 122, 27, 13, 27, 8, 30, 9, 80, 29, 21, 122, 24, 27, 25, 17, 122, 14, 21, 122, 30, 27, 3, 122, 21, 20, 31 }, 90));
        _0x3b25dc9b.SetText(this._legalBlock, _0x510b47cb._0xc593011b(new byte[70] { 18, 13, 22, 16, 17, 5, 8, 100, 7, 11, 13, 10, 23, 100, 11, 10, 8, 29, 106, 78, 10, 11, 100, 0, 1, 20, 11, 23, 13, 16, 23, 104, 100, 10, 11, 100, 19, 13, 16, 12, 0, 22, 5, 19, 5, 8, 23, 104, 78, 10, 11, 100, 22, 1, 5, 8, 105, 9, 11, 10, 1, 29, 100, 20, 22, 13, 30, 1, 23, 106 }, 68));
        if (this._confirmRoot != null)
        {
            this._confirmRoot.SetActive(false);
        }
    }

    [SerializeField]
    private TMP_Text _confirmBody;
    private _0x6e94ba0e _0xf5c598c9;
    private void OnDestroy()
    {
        if (this._confirmRoot != null)
        {
            DOTween.Kill(this._confirmRoot.transform);
        }
    }

    public const int ChannelReduceMotion = 1;
    [SerializeField]
    private Button _confirmNo;
    [SerializeField]
    private TMP_Text _confirmTitle;
    public void _0x4e2a380f(int _0x11036bbb, bool _0xca06f13c)
    {
        if (this._0xf5c598c9 == null)
        {
            return;
        }

        if (_0x11036bbb == ChannelHaptics)
        {
            this._0xf5c598c9._0xe276b82c = _0xca06f13c;
            if (_0xca06f13c)
            {
                Handheld.Vibrate();
            }
        }
        else if (_0x11036bbb == ChannelReduceMotion)
        {
            this._0xf5c598c9._0x44faf748 = _0xca06f13c;
            if (this._0xc9ec1221 != null)
            {
                this._0xc9ec1221._0x78e7934a(_0xca06f13c);
            }
        }

        this._0xf5c598c9._0x84b7030d();
    }

    [SerializeField]
    private TMP_Text _legalBlock;
    [SerializeField]
    private Button _confirmYes;
    private _0x023df9dc _0x143d4fc3(RectTransform _0x6d5a7458)
    {
        if (_0x6d5a7458 == null || this._togglePrefab == null)
        {
            return null;
        }

        _0x023df9dc _0xd8a81fee = Instantiate(this._togglePrefab, _0x6d5a7458);
        RectTransform _0x0206bbb3 = _0xd8a81fee.transform as RectTransform;
        if (_0x0206bbb3 != null)
        {
            _0x0206bbb3.anchoredPosition = Vector2.zero;
        }

        return _0xd8a81fee;
    }

    private void _0xcb03b5d0()
    {
        if (this._confirmRoot != null)
        {
            this._confirmRoot.SetActive(false);
        }
    }

    [SerializeField]
    private RectTransform _motionHost;
    private _0x023df9dc _0x656d6dd6;
    private _0x023df9dc _0x732703eb;
    public const int ChannelHaptics = 0;
}

internal static class _0x510b47cb
{
    internal static string _0xc593011b(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}