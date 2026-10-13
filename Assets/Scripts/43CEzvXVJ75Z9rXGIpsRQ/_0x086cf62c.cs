using UnityEngine;

/// Puts this game's splash content inside the template splash panel.
///
/// The splash lives three prefabs deep, so there is no scene object to parent to in the
/// YAML. The host arrives from the template singleton instead - SplashPanel.Instance - and
/// the view goes in as a child of its Content. No name, no path, nothing obfuscation can
/// rename.
public sealed class _0x086cf62c : MonoBehaviour
{
    private void Start()
    {
        _0x8f9b1458 _0xcfc96492 = _0x8f9b1458.Instance;
        if (_0xcfc96492 == null || this._splashViewPrefab == null)
        {
            return;
        }

        Transform _0x8f759f0d = _0xcfc96492.Content != null ? _0xcfc96492.Content.transform : _0xcfc96492.transform;
        _0x942807f6 _0x3e09b058 = Instantiate(this._splashViewPrefab, _0x8f759f0d);
        RectTransform _0x9995f25a = _0x3e09b058.transform as RectTransform;
        if (_0x9995f25a != null)
        {
            _0x9995f25a.anchorMin = Vector2.zero;
            _0x9995f25a.anchorMax = Vector2.one;
            _0x9995f25a.offsetMin = Vector2.zero;
            _0x9995f25a.offsetMax = Vector2.zero;
            _0x9995f25a.localScale = Vector3.one;
        }

        // Draw order is sibling order: going in FIRST keeps our ocean scrim underneath the
        // template loading bar instead of veiling it.
        _0x3e09b058.transform.SetAsFirstSibling();
        _0x3e09b058._0x24987d4c(_0xcfc96492.AnimationSlider);
    }

    [SerializeField]
    private _0x942807f6 _splashViewPrefab;
}