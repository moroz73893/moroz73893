using UnityEngine;

/// The TROPICAL preset, overridden with this brief's ocean and turquoise hexes. Every
/// colour the game draws comes from here.
///
/// There is ONE font material for the whole app, so every caption shares one outline
/// (#0A2440). The four surface colours below are surface colours ONLY and are never
/// passed as a text colour: a dark face on a dark outline is a blot no backing can
/// rescue (rule C.14). Text uses Cream / Sun / Turquoise / Green / Coral / Muted, all of
/// which clear 6:1 against the outline.
public sealed class _0xa8208ec2
{
    // --- accents, usable for text and for fills ---
    public static Color Turquoise = new Color(0f, 0.788f, 0.784f, 1f); // #00C9C8
    public static Color Edge = new Color(0.498f, 0.914f, 0.910f, 1f); // #7FE9E8
    public static Color FromChannels(int _0x72b5ce49, int _0x4a7b8595, int _0x6b466cf8, float _0x6ac26e4d)
    {
        return new Color(_0x72b5ce49 / 255f, _0x4a7b8595 / 255f, _0x6b466cf8 / 255f, _0x6ac26e4d);
    }

    public static Color Coral = new Color(1f, 0.463f, 0.341f, 1f); // #FF7657
    public static Color Surface = new Color(0.082f, 0.286f, 0.435f, 1f); // #15496F
    public static Color Deep = new Color(0.043f, 0.141f, 0.251f, 1f); // #0B2440
    public static Color Muted = new Color(0.561f, 0.733f, 0.816f, 1f); // #8FBBD0
    public static Color Sun = new Color(1f, 0.831f, 0.278f, 1f); // #FFD447
    /// Wedge label colour. The gold band carries gems instead of a label, so the only
    /// dark-plate case here is the treasure and bonus wedges, which still take Cream.
    public static Color WedgeLabel(int _0x0da66a86)
    {
        return Cream;
    }

    /// Wedge fill for a tint slot of WheelTable. Index order matches the TintXxx consts.
    public static Color WedgeTint(int _0x6d30b10e)
    {
        if (_0x6d30b10e == _0x18daa9a8.TintDud)
        {
            return new Color(0.082f, 0.286f, 0.435f, 1f);
        }

        if (_0x6d30b10e == _0x18daa9a8.TintLow)
        {
            return new Color(0.110f, 0.361f, 0.522f, 1f);
        }

        if (_0x6d30b10e == _0x18daa9a8.TintMid)
        {
            return new Color(0.071f, 0.584f, 0.624f, 1f);
        }

        if (_0x6d30b10e == _0x18daa9a8.TintHigh)
        {
            return new Color(0f, 0.788f, 0.784f, 1f);
        }

        if (_0x6d30b10e == _0x18daa9a8.TintGold)
        {
            return new Color(1f, 0.831f, 0.278f, 1f);
        }

        if (_0x6d30b10e == _0x18daa9a8.TintTreasure)
        {
            return new Color(1f, 0.463f, 0.341f, 1f);
        }

        return new Color(0.220f, 0.788f, 0.541f, 1f);
    }

    // --- surfaces: never a text colour ---
    public static Color Ink = new Color(0.039f, 0.141f, 0.251f, 1f); // #0A2440
    public static readonly string PresetName = _0x984d1036._0xd95c30e3(new byte[8] { 140, 138, 151, 136, 145, 155, 153, 148 }, 216);
    public static Color Shadow = new Color(0.016f, 0.071f, 0.122f, 1f); // #04121F
    // --- text ---
    public static Color Cream = new Color(1f, 0.965f, 0.890f, 1f); // #FFF6E3
    public static Color Ocean = new Color(0.071f, 0.231f, 0.396f, 1f); // #123B65
    public static Color Green = new Color(0.220f, 0.788f, 0.541f, 1f); // #38C98A
    public static Color Fade(Color _0x0ad573b6, float _0x16d406ce)
    {
        return new Color(_0x0ad573b6.r, _0x0ad573b6.g, _0x0ad573b6.b, _0x16d406ce);
    }

    public static Color Sky = new Color(0.749f, 0.902f, 0.902f, 1f); // #BFE6E6
    public static Color Raised = new Color(0.110f, 0.361f, 0.522f, 1f); // #1C5C85
}

internal static class _0x984d1036
{
    internal static string _0xd95c30e3(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}