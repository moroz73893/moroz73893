using UnityEngine;
using UnityEngine.UI;

/// Lays the twelve wedges out from the session's generated order. Draw order is
/// hierarchy order (rule C.13): the face plate is created FIRST, the wedges on top of it,
/// and the rim - a ring with a transparent middle - last, because it surrounds the
/// content instead of covering it. Nothing opaque is ever placed above the wedges.
public sealed class _0xedd64b64 : MonoBehaviour
{
    private Sprite _0x226b4d30(int _0xea2259f1)
    {
        if (_0xea2259f1 < 0 || this._gemSprites == null || _0xea2259f1 >= this._gemSprites.Length)
        {
            return null;
        }

        return this._gemSprites[_0xea2259f1];
    }

    [SerializeField]
    private float _labelRadiusFraction = 0.33f;
    public void _0xb7f2bfa3(_0x0435f2a6[] _0xea1249d5, float _0xe1d537ce)
    {
        if (this._wedgeHost == null || this._wedgePrefab == null || _0xea1249d5 == null)
        {
            return;
        }

        if (this._0x42010934 != null)
        {
            for (int _0x58565c11 = 0; _0x58565c11 < this._0x42010934.Length; _0x58565c11++)
            {
                if (this._0x42010934[_0x58565c11] != null)
                {
                    Destroy(this._0x42010934[_0x58565c11].gameObject);
                }
            }
        }

        this._0x42010934 = new _0x779dbee2[_0xea1249d5.Length];
        float _0x2dee43c9 = _0xe1d537ce * this._labelRadiusFraction;
        for (int _0x5ab5ddfe = 0; _0x5ab5ddfe < _0xea1249d5.Length; _0x5ab5ddfe++)
        {
            _0x779dbee2 _0xa32e7bbe = Instantiate(this._wedgePrefab, this._wedgeHost);
            RectTransform _0x4b7e4d8a = _0xa32e7bbe.transform as RectTransform;
            if (_0x4b7e4d8a != null)
            {
                _0x4b7e4d8a.anchoredPosition = Vector2.zero;
                _0x4b7e4d8a.sizeDelta = new Vector2(_0xe1d537ce, _0xe1d537ce);
            }

            _0xa32e7bbe._0x2530af78(_0xea1249d5[_0x5ab5ddfe], this._faceSprite, this._0x226b4d30(_0xea1249d5[_0x5ab5ddfe].GemIndex), _0x2dee43c9);
            this._0x42010934[_0x5ab5ddfe] = _0xa32e7bbe;
        }
    }

    [SerializeField]
    private _0x779dbee2 _wedgePrefab;
    [SerializeField]
    private Sprite[] _gemSprites;
    private _0x779dbee2[] _0x42010934;
    [SerializeField]
    private Sprite _faceSprite;
    [SerializeField]
    private RectTransform _wedgeHost;
    public _0x779dbee2[] _0x0194faaf
    {
        get
        {
            return this._0x42010934;
        }
    }

    public _0x779dbee2 _0x29af5aa4(int _0xdf926181)
    {
        if (this._0x42010934 == null || _0xdf926181 < 0 || _0xdf926181 >= this._0x42010934.Length)
        {
            return null;
        }

        return this._0x42010934[_0xdf926181];
    }
}