using TMPro;
using UnityEngine;

/// The Fortune Meter: twelve pips that only ever fill. There is no drain and no clock
/// anywhere in this scene, which is why a run with zero taps never ends (rule C.5).
public sealed class _0x412f7676 : MonoBehaviour
{
    public void _0xa5496ccb(Color _0x19f6dd6c)
    {
        if (this._0x484f123f == null)
        {
            return;
        }

        for (int _0x04bea3be = 0; _0x04bea3be < this._0x484f123f.Length; _0x04bea3be++)
        {
            this._0x484f123f[_0x04bea3be]._0x53b4bb40(_0x19f6dd6c);
        }
    }

    [SerializeField]
    private float _pipGap = 14f;
    public void _0x0f21715e()
    {
        if (this._row == null || this._pipPrefab == null)
        {
            return;
        }

        int _0x8344a019 = _0x728dc014.ChargesPerIsland;
        this._0x484f123f = new _0xa66129c9[_0x8344a019];
        float _0x2c38359a = this._pipWidth + this._pipGap;
        float _0xba573625 = -((_0x8344a019 - 1) * _0x2c38359a) * 0.5f;
        for (int _0x97f3756e = 0; _0x97f3756e < _0x8344a019; _0x97f3756e++)
        {
            _0xa66129c9 _0xe46581de = Instantiate(this._pipPrefab, this._row);
            RectTransform _0x9265c9e5 = _0xe46581de.transform as RectTransform;
            if (_0x9265c9e5 != null)
            {
                _0x9265c9e5.anchoredPosition = new Vector2(_0xba573625 + (_0x97f3756e * _0x2c38359a), 0f);
            }

            _0xe46581de._0x1a96900a(false, false);
            this._0x484f123f[_0x97f3756e] = _0xe46581de;
        }
    }

    [SerializeField]
    private float _pipWidth = 62f;
    [SerializeField]
    private RectTransform _row;
    private _0xa66129c9[] _0x484f123f;
    [SerializeField]
    private _0xa66129c9 _pipPrefab;
    public void _0x02f6584b(int charges, int _0xf0488dc4, bool _0x527a9739)
    {
        if (this._0x484f123f != null)
        {
            for (int _0x44eff91f = 0; _0x44eff91f < this._0x484f123f.Length; _0x44eff91f++)
            {
                this._0x484f123f[_0x44eff91f]._0x1a96900a(_0x44eff91f < charges, _0x527a9739);
            }
        }

        _0x3b25dc9b.SetText(this._label, charges + _0x1293fc3d._0xaf30e8de(new byte[3] { 88, 87, 88 }, 120) + _0xf0488dc4 + _0x1293fc3d._0xaf30e8de(new byte[8] { 34, 65, 74, 67, 80, 69, 71, 81 }, 2));
    }

    [SerializeField]
    private TMP_Text _label;
}

internal static class _0x1293fc3d
{
    internal static string _0xaf30e8de(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}