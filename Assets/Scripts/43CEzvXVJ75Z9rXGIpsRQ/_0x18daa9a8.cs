/// The twelve wedges of the prize wheel, with the non-uniform angles that make the
/// jackpot rare without pretending the slices are equal. The angles sum to exactly 360
/// (62+46+42+62+36+27+18+6+6+6+28+21), so a wedge's probability is Angle / 360.
///
/// The three 6-degree wedges are the GOLD BAND: they are kept together as one block by
/// the order generator, and they carry gems instead of a label because 6 degrees is far
/// too thin for text.
public sealed class _0x18daa9a8
{
    public const int GemGreen = 0;
    public const int GemNone = -1;
    public const int TintHigh = 3;
    // Tint slots the view maps to palette colours; kept as plain ints so this file
    // names no UnityEngine type and can be compiled and run headlessly.
    public const int TintDud = 0;
    public _0x0435f2a6[] _0x44f80fbe()
    {
        return new _0x0435f2a6[]
        {
            new _0x0435f2a6(_0xf64f5669.Dud, 62, 0f, _0xd152459c._0x4a6aab8b(new byte[7] { 4, 8, 4, 8, 9, 18, 19 }, 71), GemNone, 1, TintDud, false),
            new _0x0435f2a6(_0xf64f5669.Multiplier, 46, 0.5f, _0xd152459c._0x4a6aab8b(new byte[4] { 219, 147, 141, 150 }, 163), GemNone, 1, TintLow, false),
            new _0x0435f2a6(_0xf64f5669.Multiplier, 42, 1f, _0xd152459c._0x4a6aab8b(new byte[2] { 142, 199 }, 246), GemNone, 1, TintLow, false),
            new _0x0435f2a6(_0xf64f5669.Dud, 62, 0f, _0xd152459c._0x4a6aab8b(new byte[7] { 42, 38, 42, 38, 39, 60, 61 }, 105), GemNone, 1, TintDud, false),
            new _0x0435f2a6(_0xf64f5669.Multiplier, 36, 0.5f, _0xd152459c._0x4a6aab8b(new byte[4] { 202, 130, 156, 135 }, 178), GemNone, 1, TintLow, false),
            new _0x0435f2a6(_0xf64f5669.Multiplier, 27, 1.5f, _0xd152459c._0x4a6aab8b(new byte[4] { 214, 159, 128, 155 }, 174), GemNone, 1, TintMid, false),
            new _0x0435f2a6(_0xf64f5669.Multiplier, 18, 2f, _0xd152459c._0x4a6aab8b(new byte[2] { 158, 212 }, 230), GemNone, 1, TintMid, false),
            new _0x0435f2a6(_0xf64f5669.Multiplier, 6, 3f, _0xd152459c._0x4a6aab8b(new byte[2] { 109, 38 }, 21), GemGreen, 1, TintGold, true),
            new _0x0435f2a6(_0xf64f5669.Multiplier, 6, 5f, _0xd152459c._0x4a6aab8b(new byte[2] { 179, 254 }, 203), GemGold, 1, TintGold, true),
            new _0x0435f2a6(_0xf64f5669.Multiplier, 6, 10f, _0xd152459c._0x4a6aab8b(new byte[3] { 95, 22, 23 }, 39), GemCoral, 2, TintGold, true),
            new _0x0435f2a6(_0xf64f5669.Treasure, 28, 0f, _0xd152459c._0x4a6aab8b(new byte[8] { 77, 75, 92, 88, 74, 76, 75, 92 }, 25), GemNone, 2, TintTreasure, false),
            new _0x0435f2a6(_0xf64f5669.BonusSpin, 21, 0f, _0xd152459c._0x4a6aab8b(new byte[5] { 231, 234, 235, 240, 246 }, 165), GemNone, 1, TintBonus, false),
        };
    }

    public const int GemGold = 1;
    public const int TintMid = 2;
    public const int FullCircle = 360;
    public const int TintGold = 4;
    public const int TintTreasure = 5;
    public const int TintBonus = 6;
    public const int GemCoral = 2;
    /// Sum of the authored angles. A harness asserts this is 360 rather than trusting it.
    public int _0x726f69f3()
    {
        _0x0435f2a6[] _0x0495a64c = this._0x44f80fbe();
        int _0xbafe82b1 = 0;
        for (int _0xf3337327 = 0; _0xf3337327 < _0x0495a64c.Length; _0xf3337327++)
        {
            _0xbafe82b1 += _0x0495a64c[_0xf3337327].Angle;
        }

        return _0xbafe82b1;
    }

    public const int TintLow = 1;
    public const int SectorCount = 12;
}

internal static class _0xd152459c
{
    internal static string _0x4a6aab8b(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}