using UnityEngine;

/// Everything that outlives a scene, behind an instance API over PlayerPrefs. Cross-scene
/// data travels here and never through a static field of ours.
///
/// Every key is an explicit string literal - never nameof, which obfuscation rewrites -
/// and no static field initialiser here depends on another, which is what kills a type
/// outright once string encryption turns a const into a runtime-initialised field.
public sealed class _0x6e94ba0e
{
    public void _0xece5d710()
    {
        this._0x32e35cf7 = _0xf5115610.StartingCoins;
        this._0xf6321898 = 0;
        this._0x0a5c913e = 0;
        this._0x8c2a2200 = 0;
        this._0xfa787124 = 0;
        this._0xd301b78c = 0;
        this._0x8a8d6ea6 = 0;
        this._0xb63d08f8 = 0;
        this._0x4f69350e = 0;
        this._0x857ecc6b = 0;
        this._0xd0c24b4c = string.Empty;
        this._0x9b6a7dd0 = 0;
        for (int _0x55238a92 = 0; _0x55238a92 < 3; _0x55238a92++)
        {
            this._0xe7ff2403(_0x55238a92, 0);
        }

        PlayerPrefs.Save();
    }

    /// The purse. It is mirrored into the template's own counter so MoneyCount stays in
    /// step, but only once BasicController exists - the setter of PlayerSYSTEM.Coins
    /// refreshes every MoneyCount through that singleton.
    public int _0x32e35cf7
    {
        get
        {
            return PlayerPrefs.GetInt(KeyCoins, _0xf5115610.StartingCoins);
        }

        set
        {
            PlayerPrefs.SetInt(KeyCoins, value);
            if (_0xfc90c1ec.Instance != null)
            {
                _0x47dc124a._0xd6107ecd._0xdfb099ed = value;
            }
        }
    }

    private static readonly string KeyCoins = _0x1cf0f3ad._0x1262c347(new byte[11] { 43, 36, 18, 46, 34, 36, 35, 62, 18, 59, 124 }, 77);
    public int _0x8a8d6ea6
    {
        get
        {
            return PlayerPrefs.GetInt(KeyJackpot, 0);
        }

        set
        {
            PlayerPrefs.SetInt(KeyJackpot, value);
        }
    }

    public int _0x8c2a2200
    {
        get
        {
            return PlayerPrefs.GetInt(KeySpins, 0);
        }

        set
        {
            PlayerPrefs.SetInt(KeySpins, value);
        }
    }

    private static readonly string KeyChests = _0x1cf0f3ad._0x1262c347(new byte[12] { 33, 46, 24, 36, 47, 34, 52, 51, 52, 24, 49, 118 }, 71);
    public bool _0xa81d5a55()
    {
        return this._0xd0c24b4c == this._0xb602bd8c();
    }

    public int _0x51fc6247
    {
        get
        {
            return PlayerPrefs.GetInt(KeySession, 0);
        }

        set
        {
            PlayerPrefs.SetInt(KeySession, value);
        }
    }

    public void _0xa0338909()
    {
        if (PlayerPrefs.GetInt(KeyFirstRun, 0) == 1)
        {
            return;
        }

        PlayerPrefs.SetInt(KeyFirstRun, 1);
        this._0x32e35cf7 = _0xf5115610.StartingCoins;
        PlayerPrefs.Save();
    }

    public void _0xe7ff2403(int _0x53822fd5, int _0x3bd3483c)
    {
        PlayerPrefs.SetInt(KeyChallenge + _0x53822fd5, _0x3bd3483c);
    }

    public int _0xd301b78c
    {
        get
        {
            return PlayerPrefs.GetInt(KeyKeys, 0);
        }

        set
        {
            PlayerPrefs.SetInt(KeyKeys, value);
        }
    }

    public int _0x4f69350e
    {
        get
        {
            return PlayerPrefs.GetInt(KeyBestWin, 0);
        }

        set
        {
            PlayerPrefs.SetInt(KeyBestWin, value);
        }
    }

    private static readonly string KeySpins = _0x1cf0f3ad._0x1262c347(new byte[11] { 177, 190, 136, 164, 167, 190, 185, 164, 136, 161, 230 }, 215);
    public int _0xb63d08f8
    {
        get
        {
            return PlayerPrefs.GetInt(KeyClaimed, 0);
        }

        set
        {
            PlayerPrefs.SetInt(KeyClaimed, value);
        }
    }

    public void _0x84b7030d()
    {
        PlayerPrefs.Save();
    }

    private static readonly string KeySession = _0x1cf0f3ad._0x1262c347(new byte[13] { 112, 127, 73, 101, 115, 101, 101, 127, 121, 120, 73, 96, 39 }, 22);
    private static readonly string KeyMeter = _0x1cf0f3ad._0x1262c347(new byte[11] { 38, 41, 31, 45, 37, 52, 37, 50, 31, 54, 113 }, 64);
    public int _0x9b6a7dd0
    {
        get
        {
            return PlayerPrefs.GetInt(KeyAwards, 0);
        }

        set
        {
            PlayerPrefs.SetInt(KeyAwards, value);
        }
    }

    private static readonly string KeyReduceMotion = _0x1cf0f3ad._0x1262c347(new byte[19] { 1, 14, 56, 21, 2, 3, 18, 4, 2, 56, 10, 8, 19, 14, 8, 9, 56, 17, 86 }, 103);
    public int _0x0a5c913e
    {
        get
        {
            return PlayerPrefs.GetInt(KeyMeter, 0);
        }

        set
        {
            PlayerPrefs.SetInt(KeyMeter, value);
        }
    }

    private static readonly string KeyBestWin = _0x1cf0f3ad._0x1262c347(new byte[13] { 28, 19, 37, 24, 31, 9, 14, 13, 19, 20, 37, 12, 75 }, 122);
    public int _0xfa787124
    {
        get
        {
            return PlayerPrefs.GetInt(KeyChests, 0);
        }

        set
        {
            PlayerPrefs.SetInt(KeyChests, value);
        }
    }

    public bool _0x44faf748
    {
        get
        {
            return PlayerPrefs.GetInt(KeyReduceMotion, 0) == 1;
        }

        set
        {
            PlayerPrefs.SetInt(KeyReduceMotion, value ? 1 : 0);
        }
    }

    private static readonly string KeyJackpot = _0x1cf0f3ad._0x1262c347(new byte[13] { 209, 222, 232, 221, 214, 212, 220, 199, 216, 195, 232, 193, 134 }, 183);
    public bool _0xe276b82c
    {
        get
        {
            return PlayerPrefs.GetInt(KeyHaptics, 1) == 1;
        }

        set
        {
            PlayerPrefs.SetInt(KeyHaptics, value ? 1 : 0);
        }
    }

    private static readonly string KeyClaimed = _0x1cf0f3ad._0x1262c347(new byte[13] { 111, 96, 86, 106, 101, 104, 96, 100, 108, 109, 86, 127, 56 }, 9);
    /// Today as a plain sortable date string; a missed day resets the streak to day 1.
    /// No network and no server time are involved.
    public string _0xb602bd8c()
    {
        return System.DateTime.UtcNow.Date.ToString(_0x1cf0f3ad._0x1262c347(new byte[8] { 56, 56, 56, 56, 12, 12, 37, 37 }, 65));
    }

    private static readonly string KeyStreakDate = _0x1cf0f3ad._0x1262c347(new byte[17] { 105, 102, 80, 124, 123, 125, 106, 110, 100, 80, 107, 110, 123, 106, 80, 121, 62 }, 15);
    private static readonly string KeyHaptics = _0x1cf0f3ad._0x1262c347(new byte[13] { 93, 82, 100, 83, 90, 75, 79, 82, 88, 72, 100, 77, 10 }, 59);
    public int _0x009dc629(int _0xdef594ca)
    {
        return PlayerPrefs.GetInt(KeyChallenge + _0xdef594ca, 0);
    }

    private static readonly string KeyStreakDay = _0x1cf0f3ad._0x1262c347(new byte[16] { 202, 197, 243, 223, 216, 222, 201, 205, 199, 243, 200, 205, 213, 243, 218, 157 }, 172);
    private static readonly string KeyChallenge = _0x1cf0f3ad._0x1262c347(new byte[16] { 121, 118, 64, 124, 119, 126, 115, 115, 122, 113, 120, 122, 64, 105, 46, 64 }, 31);
    private static readonly string KeyKeys = _0x1cf0f3ad._0x1262c347(new byte[10] { 195, 204, 250, 206, 192, 220, 214, 250, 211, 148 }, 165);
    public string _0xd0c24b4c
    {
        get
        {
            return PlayerPrefs.GetString(KeyStreakDate, string.Empty);
        }

        set
        {
            PlayerPrefs.SetString(KeyStreakDate, value);
        }
    }

    private static readonly string KeyFirstRun = _0x1cf0f3ad._0x1262c347(new byte[13] { 68, 75, 125, 81, 86, 67, 80, 86, 71, 70, 125, 84, 19 }, 34);
    private static readonly string KeyIsland = _0x1cf0f3ad._0x1262c347(new byte[12] { 184, 183, 129, 183, 173, 178, 191, 176, 186, 129, 168, 239 }, 222);
    public int _0x857ecc6b
    {
        get
        {
            return PlayerPrefs.GetInt(KeyStreakDay, 0);
        }

        set
        {
            PlayerPrefs.SetInt(KeyStreakDay, value);
        }
    }

    private static readonly string KeyAwards = _0x1cf0f3ad._0x1262c347(new byte[12] { 148, 155, 173, 147, 133, 147, 128, 150, 129, 173, 132, 195 }, 242);
    public int _0xf6321898
    {
        get
        {
            return PlayerPrefs.GetInt(KeyIsland, 0);
        }

        set
        {
            PlayerPrefs.SetInt(KeyIsland, value);
        }
    }
}

internal static class _0x1cf0f3ad
{
    internal static string _0x1262c347(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}