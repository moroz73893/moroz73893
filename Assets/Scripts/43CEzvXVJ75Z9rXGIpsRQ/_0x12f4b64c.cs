using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// The seven-day streak track plus three daily challenges. Claiming pays coins and shows
/// it three ways at once - the tile flips state, the coin pill punches and a banner rises
/// - because a button that changes something has to say so on screen (rule C.7).
public sealed class _0x12f4b64c : MonoBehaviour
{
    private _0xa701664a[] _0x4e8d0ba0;
    private _0x6e94ba0e _0x139cb729;
    private float _0xd0299f26 = 1f;
    [SerializeField]
    private float _challengeBarWidth = 420f;
    public const int ChallengeCount = 3;
    [SerializeField]
    private RectTransform _rowOne;
    private void _0xa54df3a2()
    {
        for (int _0x658ff06d = 0; _0x658ff06d < ChallengeCount; _0x658ff06d++)
        {
            int _0xc12230a3 = this._0x139cb729._0x009dc629(_0x658ff06d);
            int _0xbf857838 = this._0x8c8c7cb5[_0x658ff06d];
            if (_0xc12230a3 > _0xbf857838)
            {
                _0xc12230a3 = _0xbf857838;
            }

            if (this._challengeNames != null && _0x658ff06d < this._challengeNames.Length)
            {
                _0x3b25dc9b.SetText(this._challengeNames[_0x658ff06d], this._0xaeb74030[_0x658ff06d]);
                this._challengeNames[_0x658ff06d].color = _0xa8208ec2.Cream;
            }

            if (this._challengeProgress != null && _0x658ff06d < this._challengeProgress.Length)
            {
                _0x3b25dc9b.SetText(this._challengeProgress[_0x658ff06d], _0xc12230a3 + _0xee637ce2._0x75862bb2(new byte[3] { 189, 178, 189 }, 157) + _0xbf857838);
                this._challengeProgress[_0x658ff06d].color = _0xc12230a3 >= _0xbf857838 ? _0xa8208ec2.Green : _0xa8208ec2.Sky;
            }

            if (this._challengeBars != null && _0x658ff06d < this._challengeBars.Length && this._challengeBars[_0x658ff06d] != null)
            {
                float _0x6d88a89c = Mathf.Clamp01((float)_0xc12230a3 / _0xbf857838);
                RectTransform _0x94532f7b = this._challengeBars[_0x658ff06d];
                _0x94532f7b.sizeDelta = new Vector2(this._challengeBarWidth * _0x6d88a89c, _0x94532f7b.sizeDelta.y);
            }
        }
    }

    public const int DailyStep = 500;
    public const int StreakLength = 7;
    [SerializeField]
    private TMP_Text[] _challengeNames;
    [SerializeField]
    private float _tilePitch = 264f;
    [SerializeField]
    private RectTransform _rowTwo;
    [SerializeField]
    private TMP_Text _banner;
    [SerializeField]
    private Image _unclaimedDot;
    private readonly string[] _0xaeb74030 = new string[]
    {
        _0xee637ce2._0x75862bb2(new byte[13] { 178, 177, 168, 175, 193, 208, 209, 193, 181, 168, 172, 164, 178 }, 225),
        _0xee637ce2._0x75862bb2(new byte[13] { 120, 103, 114, 121, 23, 4, 23, 116, 127, 114, 100, 99, 100 }, 55),
        _0xee637ce2._0x75862bb2(new byte[19] { 7, 10, 5, 15, 107, 10, 107, 51, 120, 107, 4, 25, 107, 9, 14, 31, 31, 14, 25 }, 75)
    };
    private void _0x852e35b4()
    {
        if (this._0x139cb729 == null || this._0x139cb729._0xa81d5a55())
        {
            return;
        }

        int _0x4bea4d47 = this._0x139cb729._0x857ecc6b + 1;
        if (_0x4bea4d47 > StreakLength)
        {
            _0x4bea4d47 = 1;
        }

        int _0xca2b18ed = DailyStep * _0x4bea4d47;
        this._0x139cb729._0x857ecc6b = _0x4bea4d47;
        this._0x139cb729._0xd0c24b4c = this._0x139cb729._0xb602bd8c();
        this._0x139cb729._0x32e35cf7 = this._0x139cb729._0x32e35cf7 + _0xca2b18ed;
        this._0x139cb729._0x84b7030d();
        this._0x00a80fff();
        this._0x1f2851b6(_0xee637ce2._0x75862bb2(new byte[1] { 145 }, 186) + _0x3b25dc9b.Grouped(_0xca2b18ed) + _0xee637ce2._0x75862bb2(new byte[6] { 105, 10, 6, 0, 7, 26 }, 73));
        if (this._0x1243bd7c != null)
        {
            this._0x1243bd7c._0x37cc5d17();
        }
    }

    [SerializeField]
    private RectTransform[] _challengeBars;
    public const int ChallengeReward = 400;
    private float _0x8c19ef78;
    private readonly int[] _0x8c8c7cb5 = new int[]
    {
        10,
        3,
        1
    };
    [SerializeField]
    private _0xa701664a _tilePrefab;
    public void _0x00a80fff()
    {
        if (this._0x139cb729 == null)
        {
            return;
        }

        int _0x906e267f = this._0x139cb729._0x857ecc6b;
        bool _0xa520174d = this._0x139cb729._0xa81d5a55();
        int _0x9a9935ef = _0xa520174d ? _0x906e267f - 1 : _0x906e267f;
        if (_0x9a9935ef >= StreakLength)
        {
            _0x9a9935ef = StreakLength - 1;
        }

        if (this._0x4e8d0ba0 != null)
        {
            for (int _0x59e1f04e = 0; _0x59e1f04e < this._0x4e8d0ba0.Length; _0x59e1f04e++)
            {
                int _0x15a55be5 = _0xa701664a.StateLocked;
                if (_0x59e1f04e < _0x906e267f)
                {
                    _0x15a55be5 = _0xa701664a.StateClaimed;
                }
                else if (_0x59e1f04e == _0x9a9935ef && !_0xa520174d)
                {
                    _0x15a55be5 = _0xa701664a.StateToday;
                }

                this._0x4e8d0ba0[_0x59e1f04e]._0x8787a395(_0x15a55be5);
            }
        }

        if (this._claimButton != null)
        {
            this._claimButton.interactable = !_0xa520174d;
        }

        _0x3b25dc9b.SetText(this._claimLabel, _0xa520174d ? _0xee637ce2._0x75862bb2(new byte[18] { 183, 187, 185, 177, 212, 182, 181, 183, 191, 212, 160, 187, 185, 187, 166, 166, 187, 163 }, 244) : _0xee637ce2._0x75862bb2(new byte[5] { 213, 218, 215, 223, 219 }, 150));
        if (this._claimLabel != null)
        {
            this._claimLabel.color = _0xa8208ec2.Cream;
        }

        if (this._claimPlate != null)
        {
            this._claimPlate.color = _0xa520174d ? _0xa8208ec2.Fade(_0xa8208ec2.Raised, 0.6f) : _0xa8208ec2.Turquoise;
        }

        if (this._unclaimedDot != null)
        {
            this._unclaimedDot.gameObject.SetActive(!_0xa520174d);
            this._unclaimedDot.color = _0xa8208ec2.Coral;
        }

        this._0xa54df3a2();
    }

    [SerializeField]
    private TMP_Text[] _challengeProgress;
    [SerializeField]
    private TMP_Text _claimLabel;
    [SerializeField]
    private Image _claimPlate;
    private void OnDestroy()
    {
        if (this._banner != null)
        {
            DOTween.Kill(this._banner);
        }

        if (this._bannerRect != null)
        {
            DOTween.Kill(this._bannerRect);
        }
    }

    private void _0xefbad51d()
    {
        if (this._tilePrefab == null || this._rowOne == null || this._rowTwo == null)
        {
            return;
        }

        this._0x4e8d0ba0 = new _0xa701664a[StreakLength];
        for (int _0x584697ae = 0; _0x584697ae < StreakLength; _0x584697ae++)
        {
            bool _0x9ec7cc6e = _0x584697ae < 4;
            RectTransform _0x9f3a9905 = _0x9ec7cc6e ? this._rowOne : this._rowTwo;
            int _0x5f6be276 = _0x9ec7cc6e ? _0x584697ae : _0x584697ae - 4;
            int _0x6d61830e = _0x9ec7cc6e ? 4 : 3;
            _0xa701664a _0xe5137fda = Instantiate(this._tilePrefab, _0x9f3a9905);
            RectTransform _0x27b9b1f5 = _0xe5137fda.transform as RectTransform;
            if (_0x27b9b1f5 != null)
            {
                float _0x18a4a891 = -((_0x6d61830e - 1) * this._tilePitch) * 0.5f;
                _0x27b9b1f5.anchoredPosition = new Vector2(_0x18a4a891 + (_0x5f6be276 * this._tilePitch), 0f);
            }

            _0xe5137fda._0x2e5eee9c(_0x584697ae + 1, DailyStep * (_0x584697ae + 1));
            this._0x4e8d0ba0[_0x584697ae] = _0xe5137fda;
        }
    }

    private void _0x1f2851b6(string _0x176bffda)
    {
        if (this._banner == null || this._bannerRect == null)
        {
            return;
        }

        _0x3b25dc9b.SetText(this._banner, _0x176bffda);
        this._banner.color = _0xa8208ec2.Fade(_0xa8208ec2.Sun, 0f);
        this._bannerRect.anchoredPosition = new Vector2(this._bannerRect.anchoredPosition.x, this._0x8c19ef78);
        Sequence _0xcde94915 = DOTween.Sequence().SetLink(this._banner.gameObject);
        _0xcde94915.Append(this._banner.DOFade(1f, 0.25f * this._0xd0299f26));
        _0xcde94915.Join(this._bannerRect.DOAnchorPosY(this._0x8c19ef78 + 90f, 0.9f * this._0xd0299f26));
        _0xcde94915.Append(this._banner.DOFade(0f, 0.35f * this._0xd0299f26));
    }

    private _0x364c7582 _0x1243bd7c;
    public void _0x6f54e7fe(_0x364c7582 _0x586a0d3c, _0x6e94ba0e _0x1d31f200, float _0xae807ac1)
    {
        this._0x1243bd7c = _0x586a0d3c;
        this._0x139cb729 = _0x1d31f200;
        this._0xd0299f26 = _0xae807ac1;
        this._0xefbad51d();
        if (this._claimButton != null)
        {
            this._claimButton.onClick.AddListener(() => this._0x852e35b4());
        }

        if (this._bannerRect != null)
        {
            this._0x8c19ef78 = this._bannerRect.anchoredPosition.y;
        }

        if (this._banner != null)
        {
            this._banner.color = _0xa8208ec2.Fade(_0xa8208ec2.Sun, 0f);
        }

        this._0x00a80fff();
    }

    [SerializeField]
    private Button _claimButton;
    [SerializeField]
    private RectTransform _bannerRect;
}

internal static class _0xee637ce2
{
    internal static string _0x75862bb2(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}