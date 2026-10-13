using UnityEngine;
using UnityEngine.UI;

/// Wires the two buttons the game scene needs that the template HUD does not provide in a
/// usable state - BACK and PAUSE - and keeps the generated screen in step with the canvas
/// when the device rotates.
///
/// Orientation itself is never set from here: it belongs to ProjectSettings and from there
/// to the manifest, and a script that overrides it makes the build and the game disagree
/// (rule C.22). This only reacts to the rect it is given.
public sealed class _0x317381b0 : MonoBehaviour
{
    private void _0x42f419b7()
    {
        if (_0xda9f334f.Instance != null)
        {
            _0xda9f334f.Instance._0x5582d170(_0x47dc124a._0x4d40a7ba.PAUSE);
        }
    }

    [SerializeField]
    private _0x0250d15c _director;
    [SerializeField]
    private Image _pauseIcon;
    [SerializeField]
    private Image _backIcon;
    [SerializeField]
    private Button _backButton;
    private void Start()
    {
        if (this._backIcon != null)
        {
            this._backIcon.preserveAspect = true;
            this._backIcon.color = _0xa8208ec2.Cream;
        }

        if (this._pauseIcon != null)
        {
            this._pauseIcon.preserveAspect = true;
            this._pauseIcon.color = _0xa8208ec2.Cream;
        }

        if (this._backButton != null)
        {
            this._backButton.onClick.AddListener(() => this._0xecdf314c());
        }

        if (this._pauseButton != null)
        {
            this._pauseButton.onClick.AddListener(() => this._0x42f419b7());
        }
    }

    [SerializeField]
    private Button _pauseButton;
    private void _0xecdf314c()
    {
        if (this._director != null)
        {
            this._director._0xa46b1c0d();
        }

        if (_0xfc90c1ec.Instance != null)
        {
            _0xfc90c1ec.Instance._0xc04bfe9e(_0x47dc124a._0x48063541.SCENE_0);
        }
    }
}