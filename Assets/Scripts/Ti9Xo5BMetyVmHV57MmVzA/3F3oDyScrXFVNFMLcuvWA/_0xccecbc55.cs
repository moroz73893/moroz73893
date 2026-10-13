using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Canvas))]
public class _0xccecbc55 : MonoBehaviour
{
    private static void SafeAreaChanged()
    {
        _0xee68406e = Screen.safeArea;
        for (int _0x7429ce47 = 0; _0x7429ce47 < _0xe74bfe0c.Count; _0x7429ce47++)
            _0xe74bfe0c[_0x7429ce47]._0x2b2982a3();
    }

    private void Awake()
    {
        if (!_0xe74bfe0c.Contains(this))
            _0xe74bfe0c.Add(this);
        this._0x7062abc3 = this.GetComponent<Canvas>();
        this._0x7ebb5360 = this.GetComponent<RectTransform>();
        this._0x98bce546 = this.transform.Find(_0x88bd5b10._0x475a9bfe(new byte[8] { 75, 121, 126, 125, 89, 106, 125, 121 }, 24)) as RectTransform;
        if (!_0x8b2db490)
        {
            _0x9e260bdb = Screen.orientation;
            _0xa7dcac8c.x = Screen.width;
            _0xa7dcac8c.y = Screen.height;
            _0xee68406e = Screen.safeArea;
            _0x8b2db490 = true;
        }

        this._0x2b2982a3();
    }

    private static UnityEvent _0x1daba174 = new();
    private Canvas _0x7062abc3;
    private static Rect _0xee68406e = Rect.zero;
    private void Update()
    {
        if (_0xe74bfe0c[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0x9e260bdb)
            OrientationChanged();
        if (Screen.safeArea != _0xee68406e)
            SafeAreaChanged();
        if (Screen.width != _0xa7dcac8c.x || Screen.height != _0xa7dcac8c.y)
            ResolutionChanged();
    }

    private RectTransform _0x7ebb5360;
    private static ScreenOrientation _0x9e260bdb = ScreenOrientation.LandscapeLeft;
    private void OnDestroy()
    {
        if (_0xe74bfe0c != null && _0xe74bfe0c.Contains(this))
            _0xe74bfe0c.Remove(this);
    }

    private static void ResolutionChanged()
    {
        _0xa7dcac8c.x = Screen.width;
        _0xa7dcac8c.y = Screen.height;
        _0x1daba174.Invoke();
    }

    private static bool _0x8b2db490;
    private static void OrientationChanged()
    {
        _0x9e260bdb = Screen.orientation;
        _0xa7dcac8c.x = Screen.width;
        _0xa7dcac8c.y = Screen.height;
        _0x1daba174.Invoke();
    }

    private RectTransform _0x98bce546;
    private static Vector2 _0xa7dcac8c = Vector2.zero;
    private void _0x2b2982a3()
    {
        if (this._0x98bce546 == null)
            return;
        Rect _0xf1087088 = Screen.safeArea;
        Vector2 _0x1e29be5a = _0xf1087088.position;
        Vector2 _0xbab8b6d5 = _0xf1087088.position + _0xf1087088.size;
        _0x1e29be5a.x /= this._0x7062abc3.pixelRect.width;
        _0x1e29be5a.y /= this._0x7062abc3.pixelRect.height;
        _0xbab8b6d5.x /= this._0x7062abc3.pixelRect.width;
        _0xbab8b6d5.y /= this._0x7062abc3.pixelRect.height;
        this._0x98bce546.anchorMin = _0x1e29be5a;
        this._0x98bce546.anchorMax = _0xbab8b6d5;
    }

    private static readonly List<_0xccecbc55> _0xe74bfe0c = new();
}

internal static class _0x88bd5b10
{
    internal static string _0x475a9bfe(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}