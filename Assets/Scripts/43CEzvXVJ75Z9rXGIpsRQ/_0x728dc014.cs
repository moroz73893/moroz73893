/// The five islands of the archipelago: their names and the ocean tint each one paints
/// over the game background. Claiming an island repaints the scene, so the change is
/// visible in a frame rather than only in a counter (rule C.7).
public sealed class _0x728dc014
{
    /// Island 5 cleared loops back to island 1, so the game never ends on a dead screen.
    public int _0x196c0661(int _0xdc03b9b7)
    {
        int _0x500470f7 = _0xdc03b9b7 % IslandCount;
        if (_0x500470f7 < 0)
        {
            _0x500470f7 += IslandCount;
        }

        return _0x500470f7;
    }

    public int _0x7325a924(int _0xcc9418c9)
    {
        return this._0x41efdba9[this._0x196c0661(_0xcc9418c9)];
    }

    public const int ChargesPerIsland = 12;
    private readonly int[] _0xf760637f = new int[]
    {
        201,
        201,
        182,
        118,
        212
    };
    public int _0x78e72dce(int _0xb31c5d4e)
    {
        return this._0xf760637f[this._0x196c0661(_0xb31c5d4e)];
    }

    public const int IslandCount = 5;
    private readonly int[] _0x41efdba9 = new int[]
    {
        200,
        138,
        216,
        87,
        71
    };
    public string _0xce8cbce1(int _0xf3f3b34d)
    {
        return this._0x60498e97[this._0x196c0661(_0xf3f3b34d)];
    }

    public int _0x50f1c2b6(int _0xc04dd0bf)
    {
        return this._0x8eb4129e[this._0x196c0661(_0xc04dd0bf)];
    }

    // Ocean tint per island, as 0..255 channels so this file names no UnityEngine type.
    private readonly int[] _0x8eb4129e = new int[]
    {
        0,
        56,
        31,
        255,
        255
    };
    private readonly string[] _0x60498e97 = new string[]
    {
        _0x38d6cf08._0xbc3612e1(new byte[9] { 146, 131, 142, 143, 226, 129, 141, 148, 135 }, 194),
        _0x38d6cf08._0xbc3612e1(new byte[9] { 206, 194, 223, 204, 193, 173, 207, 204, 212 }, 141),
        _0x38d6cf08._0xbc3612e1(new byte[11] { 95, 82, 84, 92, 92, 93, 51, 65, 86, 86, 85 }, 19),
        _0x38d6cf08._0xbc3612e1(new byte[13] { 214, 207, 204, 195, 193, 206, 207, 160, 211, 200, 207, 210, 197 }, 128),
        _0x38d6cf08._0xbc3612e1(new byte[12] { 196, 204, 207, 199, 198, 205, 163, 194, 215, 204, 207, 207 }, 131),
    };
    public const int IslandBonusMultiplier = 10;
}

internal static class _0x38d6cf08
{
    internal static string _0xbc3612e1(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}