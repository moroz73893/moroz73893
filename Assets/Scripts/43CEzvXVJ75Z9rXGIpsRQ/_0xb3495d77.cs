using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// The six-chest bonus round. The board is reshuffled on every entry, and because the
/// multiset is fixed - three coin chests, one Fortune Key, two hermit crabs - every board
/// is valid by construction and needs no solvability retry.
///
/// The overlay is a child of the game canvas, so no Canvas of our own is created and
/// nothing here can draw over the pops.
public sealed class _0xb3495d77 : MonoBehaviour
{
    [SerializeField]
    private TMP_Text _haulExtra;
    private void _0x7d5fa9db()
    {
        if (this._haulCard == null || this._0x18467381 == null)
        {
            return;
        }

        float _0x3cca63df = this._0x18467381._0x258c40a9;
        this._haulCard.SetActive(true);
        _0x3b25dc9b.SetText(this._haulLabel, _0xa94d8e60._0x65cefe32(new byte[7] { 99, 106, 126, 103, 11, 11, 0 }, 43) + _0x3b25dc9b.Grouped(this._0x20096a9f) + _0xa94d8e60._0x65cefe32(new byte[6] { 82, 49, 61, 59, 60, 33 }, 114));
        if (this._haulLabel != null)
        {
            this._haulLabel.color = _0xa8208ec2.Sun;
        }

        if (this._haulExtra != null)
        {
            this._haulExtra.gameObject.SetActive(this._0x5844cc1c > 0);
            this._haulExtra.color = _0xa8208ec2.Green;
            _0x3b25dc9b.SetText(this._haulExtra, _0xa94d8e60._0x65cefe32(new byte[1] { 196 }, 239) + this._0x5844cc1c + _0xa94d8e60._0x65cefe32(new byte[8] { 232, 139, 128, 137, 154, 143, 141, 155 }, 200));
        }

        if (this._haulRect != null)
        {
            float _0x5f531ec8 = this._haulRect.anchoredPosition.y;
            this._haulRect.anchoredPosition = new Vector2(this._haulRect.anchoredPosition.x, _0x5f531ec8 - 90f);
            this._haulRect.DOAnchorPosY(_0x5f531ec8, 0.35f * _0x3cca63df).SetEase(Ease.OutBack).SetLink(this._haulRect.gameObject);
        }

        DOVirtual.DelayedCall(6f * _0x3cca63df, () => this._0x9178a99c()).SetLink(this.gameObject);
    }

    [SerializeField]
    private float _columnPitch = 360f;
    private void _0x3d9da9cd()
    {
        if (this._root != null)
        {
            this._root.SetActive(false);
        }

        if (this._0x18467381 != null)
        {
            this._0x18467381._0x1660dc7a();
        }
    }

    [SerializeField]
    private float _rowPitch = 340f;
    private int _0x20632e52;
    [SerializeField]
    private Sprite _keySprite;
    [SerializeField]
    private Button _backButton;
    [SerializeField]
    private TMP_Text _haulLabel;
    [SerializeField]
    private TMP_Text _backLabel;
    [SerializeField]
    private Sprite _crabSprite;
    private _0x0250d15c _0x18467381;
    private void _0x2139c05d()
    {
        _0x3b25dc9b.SetText(this._picksLabel, _0xa94d8e60._0x65cefe32(new byte[11] { 209, 200, 194, 202, 210, 161, 205, 196, 199, 213, 161 }, 129) + this._0x20632e52);
        if (this._picksLabel != null)
        {
            this._picksLabel.color = _0xa8208ec2.Cream;
        }
    }

    private _0xbd0369df[] _0xd66b1853;
    [SerializeField]
    private RectTransform _tileHost;
    [SerializeField]
    private Sprite _coinSprite;
    public void _0xffa7537b()
    {
        if (this._0x18467381 == null || this._root == null)
        {
            return;
        }

        float _0xf0f53d7d = this._0x18467381._0x258c40a9;
        this._0x20632e52 = _0x8e73d9ff.PicksPerRound;
        this._0x20096a9f = 0;
        this._0x5844cc1c = 0;
        if (this._0xd66b1853 != null)
        {
            for (int _0x5104b02a = 0; _0x5104b02a < this._0xd66b1853.Length; _0x5104b02a++)
            {
                if (this._0xd66b1853[_0x5104b02a] != null)
                {
                    this._0xd66b1853[_0x5104b02a]._0x4c267718();
                }
            }
        }

        if (this._haulCard != null)
        {
            this._haulCard.SetActive(false);
        }

        this._0x2139c05d();
        this._root.SetActive(true);
        if (this._scrim != null)
        {
            this._scrim.color = _0xa8208ec2.Fade(_0xa8208ec2.Ink, 0f);
            this._scrim.DOFade(0.72f, 0.25f * _0xf0f53d7d).SetLink(this._scrim.gameObject);
        }
    }

    [SerializeField]
    private Image _scrim;
    [SerializeField]
    private _0xbd0369df _tilePrefab;
    private int _0x20096a9f;
    private int _0x5844cc1c;
    [SerializeField]
    private RectTransform _haulRect;
    private void OnDestroy()
    {
        if (this._scrim != null)
        {
            DOTween.Kill(this._scrim);
        }

        if (this._haulRect != null)
        {
            DOTween.Kill(this._haulRect);
        }
    }

    [SerializeField]
    private GameObject _root;
    [SerializeField]
    private TMP_Text _title;
    [SerializeField]
    private TMP_Text _picksLabel;
    public void _0x23137cee(_0x0250d15c _0xa1cb4721)
    {
        this._0x18467381 = _0xa1cb4721;
        _0x3b25dc9b.SetText(this._title, _0xa94d8e60._0x65cefe32(new byte[13] { 75, 82, 88, 80, 59, 41, 59, 88, 83, 94, 72, 79, 72 }, 27));
        if (this._title != null)
        {
            this._title.color = _0xa8208ec2.Sun;
        }

        _0x3b25dc9b.SetText(this._backLabel, _0xa94d8e60._0x65cefe32(new byte[17] { 25, 26, 24, 16, 123, 15, 20, 123, 15, 19, 30, 123, 12, 19, 30, 30, 23 }, 91));
        if (this._backLabel != null)
        {
            this._backLabel.color = _0xa8208ec2.Cream;
        }

        this._0x19a72abe();
        if (this._backButton != null)
        {
            this._backButton.onClick.AddListener(() => this._0x3d9da9cd());
        }

        if (this._root != null)
        {
            this._root.SetActive(false);
        }
    }

    private void _0x9178a99c()
    {
        if (this._root != null && this._root.activeSelf)
        {
            this._0x3d9da9cd();
        }
    }

    public void _0x221f69c5(int _0x0a2b5321, _0xbd0369df _0xf007428e)
    {
        if (this._0x18467381 == null || this._0x20632e52 <= 0 || _0xf007428e == null)
        {
            return;
        }

        float _0x0f8af5d9 = this._0x18467381._0x258c40a9;
        _0xf5115610 _0x69dcb1d0 = this._0x18467381._0x46090d0c;
        int _0xd4f3663b;
        int charges;
        int win = _0x69dcb1d0._0x420958b8(_0x0a2b5321, out _0xd4f3663b, out charges);
        this._0x20632e52--;
        this._0x20096a9f += win;
        this._0x5844cc1c += charges;
        _0x6e94ba0e _0x52d5fff7 = this._0x18467381._0x38ac25cb;
        _0x52d5fff7._0xfa787124 = _0x52d5fff7._0xfa787124 + 1;
        _0x52d5fff7._0xe7ff2403(1, _0x52d5fff7._0x009dc629(1) + 1);
        if (_0xd4f3663b == _0x8e73d9ff.ContentKey)
        {
            _0x52d5fff7._0xd301b78c = _0x52d5fff7._0xd301b78c + 1;
        }

        Sprite _0xba29ef04 = this._crabSprite;
        string _0x56b0039b = _0xa94d8e60._0x65cefe32(new byte[5] { 244, 252, 225, 229, 232 }, 177);
        Color _0x3d2636dc = _0xa8208ec2.Sky;
        if (_0xd4f3663b == _0x8e73d9ff.ContentCoin)
        {
            _0xba29ef04 = this._coinSprite;
            _0x56b0039b = _0xa94d8e60._0x65cefe32(new byte[1] { 78 }, 101) + _0x3b25dc9b.Grouped(win);
            _0x3d2636dc = _0xa8208ec2.Sun;
        }
        else if (_0xd4f3663b == _0x8e73d9ff.ContentKey)
        {
            _0xba29ef04 = this._keySprite;
            _0x56b0039b = _0xa94d8e60._0x65cefe32(new byte[11] { 30, 23, 10, 12, 13, 22, 29, 120, 19, 29, 1 }, 88);
            _0x3d2636dc = _0xa8208ec2.Green;
        }

        _0xf007428e._0x4bfd42b7(_0xba29ef04, _0x56b0039b, _0x3d2636dc, _0x0f8af5d9);
        this._0x2139c05d();
        if (this._0x20632e52 > 0)
        {
            return;
        }

        if (this._0xd66b1853 != null)
        {
            for (int _0xe48e1763 = 0; _0xe48e1763 < this._0xd66b1853.Length; _0xe48e1763++)
            {
                if (this._0xd66b1853[_0xe48e1763] != null)
                {
                    this._0xd66b1853[_0xe48e1763]._0x78a644e9();
                }
            }
        }

        DOVirtual.DelayedCall(0.6f * _0x0f8af5d9, () => this._0x7d5fa9db()).SetLink(this.gameObject);
    }

    /// Six chests in a 3 x 2 grid, all spawned from one prefab so no tile can drift out of
    /// line with its neighbours.
    private void _0x19a72abe()
    {
        if (this._tileHost == null || this._tilePrefab == null)
        {
            return;
        }

        this._0xd66b1853 = new _0xbd0369df[_0x8e73d9ff.ChestCount];
        for (int _0x9e5173c6 = 0; _0x9e5173c6 < _0x8e73d9ff.ChestCount; _0x9e5173c6++)
        {
            _0xbd0369df _0xa7b94033 = Instantiate(this._tilePrefab, this._tileHost);
            RectTransform _0x1607051d = _0xa7b94033.transform as RectTransform;
            if (_0x1607051d != null)
            {
                int _0xae26d9d2 = _0x9e5173c6 % 3;
                int _0x1d3415f0 = _0x9e5173c6 / 3;
                _0x1607051d.anchoredPosition = new Vector2((_0xae26d9d2 - 1) * this._columnPitch, (0.5f - _0x1d3415f0) * this._rowPitch);
            }

            _0xa7b94033._0x61a85e36(this, _0x9e5173c6);
            this._0xd66b1853[_0x9e5173c6] = _0xa7b94033;
        }
    }

    [SerializeField]
    private GameObject _haulCard;
}

internal static class _0xa94d8e60
{
    internal static string _0x65cefe32(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}