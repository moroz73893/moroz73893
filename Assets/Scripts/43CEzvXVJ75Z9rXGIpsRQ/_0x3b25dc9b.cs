using TMPro;
using UnityEngine;

/// Rules C.10 and C.12 in one place: word wrapping OFF, line breaks by hand, autosize
/// ALWAYS on, and fontSizeMin never below the readability floor. Autosize ships
/// fontSizeMin on a long line, so a low minimum is a guaranteed unreadable caption.
public sealed class _0x3b25dc9b
{
    public static void Normalise(TMP_Text _0x434832cf)
    {
        if (_0x434832cf == null)
        {
            return;
        }

        _0x434832cf.textWrappingMode = TextWrappingModes.NoWrap;
        _0x434832cf.overflowMode = TextOverflowModes.Overflow;
        _0x434832cf.enableAutoSizing = true;
        if (_0x434832cf.fontSizeMin < UguiFloor)
        {
            _0x434832cf.fontSizeMin = UguiFloor;
        }

        if (_0x434832cf.fontSizeMax < _0x434832cf.fontSizeMin)
        {
            _0x434832cf.fontSizeMax = _0x434832cf.fontSizeMin;
        }
    }

    /// Thousands separators without Hermes-style locale surprises: the storefront never
    /// shows a currency symbol, only a grouped number.
    public static string Grouped(int _0xa92f0219)
    {
        bool _0xb94e1de4 = _0xa92f0219 < 0;
        string _0x54644b69 = (_0xb94e1de4 ? -_0xa92f0219 : _0xa92f0219).ToString();
        System.Text.StringBuilder _0x90f4fb81 = new System.Text.StringBuilder();
        int _0x580b1223 = _0x54644b69.Length % 3;
        if (_0x580b1223 == 0)
        {
            _0x580b1223 = 3;
        }

        _0x90f4fb81.Append(_0x54644b69.Substring(0, _0x580b1223));
        for (int _0x189347fb = _0x580b1223; _0x189347fb < _0x54644b69.Length; _0x189347fb += 3)
        {
            _0x90f4fb81.Append(',');
            _0x90f4fb81.Append(_0x54644b69.Substring(_0x189347fb, 3));
        }

        return _0xb94e1de4 ? _0x622dbe23._0x3c720534(new byte[1] { 86 }, 123) + _0x90f4fb81.ToString() : _0x90f4fb81.ToString();
    }

    /// Writes a string that may carry explicit line breaks. Nothing else decides where
    /// a line ends, which is why the layout is identical on every device.
    public static void SetText(TMP_Text _0x9cf6f3e0, string _0xf70e065e)
    {
        if (_0x9cf6f3e0 == null)
        {
            return;
        }

        Normalise(_0x9cf6f3e0);
        _0x9cf6f3e0.text = _0xf70e065e;
    }

    /// A label created from C# never reaches stage 5c3, so it gets its own outline here.
    /// Reading fontMaterial creates an instance; the shared asset stays intact.
    public static void ApplyOutline(TMP_Text _0xdac58f60)
    {
        if (_0xdac58f60 == null)
        {
            return;
        }

        Normalise(_0xdac58f60);
        Color _0x3cf0aa89 = _0xdac58f60.color;
        float _0xb97a3db6 = (0.299f * _0x3cf0aa89.r) + (0.587f * _0x3cf0aa89.g) + (0.114f * _0x3cf0aa89.b);
        Material _0x0da52b11 = _0xdac58f60.fontMaterial;
        _0x0da52b11.SetColor(ShaderUtilities.ID_OutlineColor, _0xb97a3db6 < 0.5f ? _0xa8208ec2.Cream : _0xa8208ec2.Ink);
        _0x0da52b11.SetFloat(ShaderUtilities.ID_OutlineWidth, 0.16f);
    }

    public const float UguiFloor = 24f;
}

internal static class _0x622dbe23
{
    internal static string _0x3c720534(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}