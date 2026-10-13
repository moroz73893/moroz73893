using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Canvas))]
public class _0x91a8b0c6 : MonoBehaviour
{
    private static void ApplySafeAreaToAll()
    {
        for (int _0x29c4eb76 = 0; _0x29c4eb76 < _0x6af4af57.Count; _0x29c4eb76++)
            _0x6af4af57[_0x29c4eb76]._0xdf58363d();
    }

    private RectTransform _0x8102ba95;
    private static bool _0x0d99d5a8;
    private static Vector2 _0x1f85f39b = Vector2.zero;
    private static Rect _0x44d7a603 = Rect.zero;
    private void _0xdf58363d()
    {
        if (this._0x8102ba95 == null)
            return;
        float screenWidth = Screen.width;
        float screenHeight = Screen.height;
        if (screenWidth <= 0f || screenHeight <= 0f)
            return;
        Rect _0x2593e795 = Screen.safeArea;
        Vector2 _0x7f46afca = _0x2593e795.position;
        Vector2 _0xae440607 = _0x2593e795.position + _0x2593e795.size;
        _0x7f46afca.x /= screenWidth;
        _0x7f46afca.y /= screenHeight;
        _0xae440607.x /= screenWidth;
        _0xae440607.y /= screenHeight;
        this._0x8102ba95.anchorMin = _0x7f46afca;
        this._0x8102ba95.anchorMax = _0xae440607;
        this._0x8102ba95.offsetMin = Vector2.zero;
        this._0x8102ba95.offsetMax = Vector2.zero;
        if (this._0x91f2bbd6 == null)
            return;
        Vector2 _0x9150f98f = _0xae440607 - _0x7f46afca;
        float _0x31f86ab2 = 2f - _0x9150f98f.x;
        float _0x2cac1527 = 2f - _0x9150f98f.y;
        this._0x91f2bbd6.referenceResolution = this._0xd47cb049 * new Vector2(_0x31f86ab2, _0x2cac1527);
    }

    private static void OrientationChanged()
    {
        _0xe0b77a63 = Screen.orientation;
        _0x1f85f39b.x = Screen.width;
        _0x1f85f39b.y = Screen.height;
        _0x44d7a603 = Screen.safeArea;
        ApplySafeAreaToAll();
        _0x025046bd.Invoke();
    }

    private static void SafeAreaChanged()
    {
        _0x44d7a603 = Screen.safeArea;
        ApplySafeAreaToAll();
    }

    private CanvasScaler _0x91f2bbd6;
    private RectTransform _0xf7ed007f;
    private void Update()
    {
        if (_0x6af4af57.Count == 0 || _0x6af4af57[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0xe0b77a63)
            OrientationChanged();
        if (Screen.safeArea != _0x44d7a603)
            SafeAreaChanged();
        if (Screen.width != _0x1f85f39b.x || Screen.height != _0x1f85f39b.y)
            ResolutionChanged();
    }

    private Canvas _0x8c231650;
    private Vector2 _0xd47cb049;
    private void OnDestroy()
    {
        if (_0x6af4af57 != null && _0x6af4af57.Contains(this))
            _0x6af4af57.Remove(this);
    }

    private void Awake()
    {
        if (!_0x6af4af57.Contains(this))
            _0x6af4af57.Add(this);
        this._0x8c231650 = this.GetComponent<Canvas>();
        this._0x91f2bbd6 = this.GetComponent<CanvasScaler>();
        if (this._0x91f2bbd6 != null)
            this._0xd47cb049 = this._0x91f2bbd6.referenceResolution;
        this._0xf7ed007f = this.GetComponent<RectTransform>();
        this._0x8102ba95 = this.transform.Find(_0x4fb18bae._0x917e56c6(new byte[8] { 64, 114, 117, 118, 82, 97, 118, 114 }, 19)) as RectTransform;
        if (!_0x0d99d5a8)
        {
            _0xe0b77a63 = Screen.orientation;
            _0x1f85f39b.x = Screen.width;
            _0x1f85f39b.y = Screen.height;
            _0x44d7a603 = Screen.safeArea;
            _0x0d99d5a8 = true;
        }

        this._0xdf58363d();
    }

    private static UnityEvent _0x025046bd = new();
    private static void ResolutionChanged()
    {
        _0x1f85f39b.x = Screen.width;
        _0x1f85f39b.y = Screen.height;
        _0x44d7a603 = Screen.safeArea;
        ApplySafeAreaToAll();
        _0x025046bd.Invoke();
    }

    private static readonly List<_0x91a8b0c6> _0x6af4af57 = new();
    private void Start()
    {
    }

    private static ScreenOrientation _0xe0b77a63 = ScreenOrientation.LandscapeLeft;
}

internal static class _0x4fb18bae
{
    internal static string _0x917e56c6(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}