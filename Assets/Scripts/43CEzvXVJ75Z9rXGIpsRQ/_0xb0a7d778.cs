using System.Collections.Generic;
using TMPro;
using UnityEngine;

// TmpContrastGuard.cs — staged into every Unity app by approve-pipeline-unity.sh
// (stage 5c3, rule C.14 in CLAUDE-unity.md). Do not edit the copy inside a project;
// edit scripts/lib/unity/TmpContrastGuard.cs.
//
// WHY: every TMP label gets an outline (C.10), and by default that outline is dark.
// A dark face colour on a dark outline merges into a smudge — the label is not
// readable on any backing (ANDROID-3627: PLAY drawn Deep #12151E on the #12151E
// outline read as a black blob). enforce-text-contrast.sh fixes colours SERIALISED
// in scenes/prefabs, but labels built at runtime from C# (UiKit.Cta, VaultUi.Caption,
// label.color = Palette.X ...) never reach a scene file, so that pass cannot see them.
//
// WHAT: after any TMP text is regenerated, compare its face colour with the outline
// colour of the material it actually renders with. Below WCAG 4.5:1 the face is
// blended toward white (dark outline) or black (light outline) until it reaches 7:1.
// Hue is kept; alpha is kept. A label whose outline was deliberately switched to a
// light colour (TextReadability-style per-label material) is measured against THAT
// outline, so intentionally dark text on a light rim is left alone. Labels without
// an outline are left alone too.
public sealed class _0xb0a7d778 : MonoBehaviour
{
    private void LateUpdate()
    {
        if (this._0x746b378d.Count == 0)
            return;
        this._0x63a5eebb.Clear();
        this._0x63a5eebb.AddRange(this._0x746b378d);
        this._0x746b378d.Clear();
        for (int _0xd921f6e9 = 0; _0xd921f6e9 < this._0x63a5eebb.Count; _0xd921f6e9++)
            Fix(this._0x63a5eebb[_0xd921f6e9]);
    }

    private readonly HashSet<TMP_Text> _0x746b378d = new HashSet<TMP_Text>();
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Boot()
    {
        if (_0x54183d78 != null)
            return;
        GameObject _0xc20ac749 = new GameObject(_0xb1224e77._0x61262ab2(new byte[16] { 62, 7, 26, 41, 5, 4, 30, 24, 11, 25, 30, 45, 31, 11, 24, 14 }, 106));
        _0xc20ac749.hideFlags = HideFlags.HideInHierarchy;
        DontDestroyOnLoad(_0xc20ac749);
        _0x54183d78 = _0xc20ac749.AddComponent<_0xb0a7d778>();
    }

    // WCAG relative luminance of an sRGB colour, and the contrast ratio of two.
    private static float Luminance(Color _0xf9aefb9d)
    {
        return 0.2126f * Linear(_0xf9aefb9d.r) + 0.7152f * Linear(_0xf9aefb9d.g) + 0.0722f * Linear(_0xf9aefb9d.b);
    }

    private static float Linear(float _0x64fe9d0b)
    {
        _0x64fe9d0b = Mathf.Clamp01(_0x64fe9d0b);
        return _0x64fe9d0b <= 0.03928f ? _0x64fe9d0b / 12.92f : Mathf.Pow((_0x64fe9d0b + 0.055f) / 1.055f, 2.4f);
    }

    // The event fires from inside the canvas rebuild. Changing the colour right there
    // would re-dirty the graphic mid-rebuild, which Unity rejects — so queue it and
    // apply in LateUpdate, which runs before the next frame's rebuild.
    private void _0xbee5ccfb(Object _0xae28bae7)
    {
        TMP_Text _0xb189c203 = _0xae28bae7 as TMP_Text;
        if (_0xb189c203 != null)
            this._0x746b378d.Add(_0xb189c203);
    }

    private void OnDisable()
    {
        if (this._0x24268198 != null)
            TMPro_EventManager.TEXT_CHANGED_EVENT.Remove(this._0x24268198);
    }

    private static void Fix(TMP_Text _0xe75a3b69)
    {
        if (_0xe75a3b69 == null || !_0xe75a3b69.isActiveAndEnabled)
            return;
        Material _0xed99f58a = _0xe75a3b69.fontSharedMaterial;
        if (_0xed99f58a == null || !_0xed99f58a.HasProperty(ShaderUtilities.ID_OutlineColor) || !_0xed99f58a.HasProperty(ShaderUtilities.ID_OutlineWidth))
            return;
        if (_0xed99f58a.GetFloat(ShaderUtilities.ID_OutlineWidth) < MinOutlineWidth)
            return;
        Color _0x8410ee93 = _0xe75a3b69.color;
        if (_0x8410ee93.a <= 0f)
            return;
        Color _0x631c486d = _0xed99f58a.GetColor(ShaderUtilities.ID_OutlineColor);
        if (Ratio(_0x8410ee93, _0x631c486d) >= MinRatio)
            return;
        Color _0xa24efeda = Luminance(_0x631c486d) < 0.5f ? Color.white : Color.black;
        Color _0x586821d2;
        if (Ratio(_0xa24efeda, _0x631c486d) < TargetRatio)
        {
            _0x586821d2 = _0xa24efeda;
        }
        else
        {
            // Smallest blend that reaches the target: contrast grows monotonically
            // with t, so a short bisection keeps as much of the hue as possible.
            float _0xb124d66a = 0f;
            float _0x8ce933ff = 1f;
            for (int _0x2586b455 = 0; _0x2586b455 < 20; _0x2586b455++)
            {
                float _0x015d1baf = (_0xb124d66a + _0x8ce933ff) * 0.5f;
                if (Ratio(Color.Lerp(_0x8410ee93, _0xa24efeda, _0x015d1baf), _0x631c486d) >= TargetRatio)
                    _0x8ce933ff = _0x015d1baf;
                else
                    _0xb124d66a = _0x015d1baf;
            }

            _0x586821d2 = Color.Lerp(_0x8410ee93, _0xa24efeda, _0x8ce933ff);
        }

        _0x586821d2.a = _0x8410ee93.a;
        _0xe75a3b69.color = _0x586821d2;
    }

    private void OnEnable()
    {
        if (this._0x24268198 == null)
            this._0x24268198 = _0xbc238bcc => this._0xbee5ccfb(_0xbc238bcc);
        TMPro_EventManager.TEXT_CHANGED_EVENT.Add(this._0x24268198);
    }

    // A lambda held in a field, never the bare method group: Plana renames the method
    // declaration but not a method-group reference (verify-unity-buttons.sh, CS0103).
    // The field keeps Add and Remove on the same delegate instance.
    private System.Action<Object> _0x24268198;
    private readonly List<TMP_Text> _0x63a5eebb = new List<TMP_Text>();
    private static float Ratio(Color _0x31f62211, Color _0x56d6a237)
    {
        float _0xb8432b90 = Luminance(_0x31f62211);
        float _0x64a1f26b = Luminance(_0x56d6a237);
        return (Mathf.Max(_0xb8432b90, _0x64a1f26b) + 0.05f) / (Mathf.Min(_0xb8432b90, _0x64a1f26b) + 0.05f);
    }

    private const float MinOutlineWidth = 0.01f;
    private static _0xb0a7d778 _0x54183d78;
    private const float TargetRatio = 7f;
    private const float MinRatio = 4.5f;
}

internal static class _0xb1224e77
{
    internal static string _0x61262ab2(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}