using TMPro;
using UnityEngine;

/// The three stake chips and the SPIN button's cost sub-label, kept in step. The chips are
/// spawned from one prefab so all three are identical by construction - a hand-placed row
/// is where "the same class of button, different size" starts.
public sealed class _0x7d37c993 : MonoBehaviour
{
    public void _0x59f4ad0d(bool _0x8b7fd2bf)
    {
        if (this._0xf889e477 == null)
        {
            return;
        }

        for (int _0xe43b0efc = 0; _0xe43b0efc < this._0xf889e477.Length; _0xe43b0efc++)
        {
            if (this._0xf889e477[_0xe43b0efc] != null)
            {
                this._0xf889e477[_0xe43b0efc]._0xb7ff47cc(_0x8b7fd2bf);
            }
        }
    }

    private _0x0250d15c _0x8551ee3e;
    public void _0x02cfd735(_0x0250d15c _0x491b3bb2, _0xf5115610 _0x17fecf75)
    {
        if (this._host == null || this._chipPrefab == null)
        {
            return;
        }

        int _0x5810edab = _0x17fecf75._0x6dd74e06;
        this._0xf889e477 = new _0x09033ffd[_0x5810edab];
        float _0x0385e20d = -((_0x5810edab - 1) * this._pitch) * 0.5f;
        for (int _0x72d58a76 = 0; _0x72d58a76 < _0x5810edab; _0x72d58a76++)
        {
            _0x09033ffd _0xeafd351b = Instantiate(this._chipPrefab, this._host);
            RectTransform _0x51400e1f = _0xeafd351b.transform as RectTransform;
            if (_0x51400e1f != null)
            {
                _0x51400e1f.anchoredPosition = new Vector2(_0x0385e20d + (_0x72d58a76 * this._pitch), 0f);
            }

            _0xeafd351b._0x629ca05a(this, _0x72d58a76, _0x17fecf75._0x8f8e4c83(_0x72d58a76));
            this._0xf889e477[_0x72d58a76] = _0xeafd351b;
        }

        this._0x8551ee3e = _0x491b3bb2;
        this._0xa5ce9514(_0x17fecf75._0x6cbf7f72, _0x17fecf75._0x92246ec2);
    }

    public void _0x9059cfd9(int _0x0bf4ab64)
    {
        if (this._0x8551ee3e != null)
        {
            this._0x8551ee3e._0x3dc2d512(_0x0bf4ab64);
        }
    }

    [SerializeField]
    private RectTransform _host;
    private _0x09033ffd[] _0xf889e477;
    [SerializeField]
    private TMP_Text _costLabel;
    [SerializeField]
    private _0x09033ffd _chipPrefab;
    public void _0xa5ce9514(int _0xc7a58a84, int bet)
    {
        if (this._0xf889e477 != null)
        {
            for (int _0x6f8107a3 = 0; _0x6f8107a3 < this._0xf889e477.Length; _0x6f8107a3++)
            {
                if (this._0xf889e477[_0x6f8107a3] != null)
                {
                    this._0xf889e477[_0x6f8107a3]._0x26c2060f(_0x6f8107a3 == _0xc7a58a84);
                }
            }
        }

        _0x3b25dc9b.SetText(this._costLabel, _0x9923d2b7._0x1d044bf3(new byte[5] { 121, 117, 105, 110, 26 }, 58) + _0x3b25dc9b.Grouped(bet));
        if (this._costLabel != null)
        {
            this._costLabel.color = _0xa8208ec2.Sky;
        }
    }

    [SerializeField]
    private float _pitch = 340f;
}

internal static class _0x9923d2b7
{
    internal static string _0x1d044bf3(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}