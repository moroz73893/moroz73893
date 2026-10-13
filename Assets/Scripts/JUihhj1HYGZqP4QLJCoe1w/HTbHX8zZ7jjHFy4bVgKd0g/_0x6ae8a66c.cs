using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0x47dc124a;

public class _0x6ae8a66c : MonoBehaviour
{
    public float StaticBlurMaterialInitialValue;
    public static _0x6ae8a66c Instance;
    private void _0x0d9ee63a()
    {
        this._0x701e7685(_0xecae2237.SPLASH);
        if (_0xfc90c1ec.Instance._0xcd9014e9 == _0x48063541.SCENE_0)
        {
        }
        else
        {
            this.Invoke(nameof(this.SwitchSplash), _0x8f9b1458.Instance.DefaultAnimationTime);
        }
    }

    public List<_0x8ae4c95e> Panels;
    private void _0x43d6919e(int _0x13431f7f)
    {
        if (_0x13431f7f == _0xecae2237.SPLASH)
            _0x8f9b1458.Instance._0xe035cb79();
        if (_0xfc90c1ec.Instance._0xcd9014e9 == _0x48063541.SCENE_0)
        {
        }
    }

    public void _0xf037c388()
    {
        this.LastPanelIndexes.RemoveAll(_0xd3221b2e => _0xd3221b2e == this.CurrentPanelIndex);
        int _0x3ef387f4 = this.LastPanelIndexes.Last();
        this._0x43d6919e(_0x3ef387f4);
        this._0x76140d6a(_0x3ef387f4);
        this.CurrentPanelIndex = _0x3ef387f4;
        this.Panels[_0x3ef387f4].Show();
    }

    [HideInInspector]
    public List<int> LastPanelIndexes = new()
    {
        1
    };
    public float ScaleDuration = 0.4f;
    private void _0xc6ce5ec0(int _0xb278c012)
    {
        this.LastPanelIndexes.Add(_0xb278c012);
        this.CurrentPanelIndex = _0xb278c012;
        for (int _0xdc3a8e05 = 0; _0xdc3a8e05 < this.Panels.Count; _0xdc3a8e05++)
            if (_0xdc3a8e05 != _0xb278c012 && this.Panels[_0xdc3a8e05] != null)
                this.Panels[_0xdc3a8e05]._0x7a2d6ca8();
    }

    private void Start()
    {
        this._0x0d9ee63a();
    }

    public bool IsShowSplashOnStart = true;
    public int CurrentPanelIndex;
    private void _0x701e7685(int _0xe6b94e98)
    {
        this._0xc6ce5ec0(_0xe6b94e98);
        this._0x43d6919e(_0xe6b94e98);
        this.CurrentPanelIndex = _0xe6b94e98;
        this.Panels[_0xe6b94e98]._0x8dda9d83();
    }

    private void _0x76140d6a(int _0xd972544b)
    {
        this.LastPanelIndexes.Add(_0xd972544b);
        this.CurrentPanelIndex = _0xd972544b;
        for (int _0xc4dfbde8 = 0; _0xc4dfbde8 < this.Panels.Count; _0xc4dfbde8++)
            if (_0xc4dfbde8 != _0xd972544b && this.Panels[_0xc4dfbde8] != null)
                this.Panels[_0xc4dfbde8]._0x7a2d6ca8();
    }

    private _0x8ae4c95e _0x72e25e86(int _0x9d06c99f)
    {
        return this.Panels[_0x9d06c99f];
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x6ae8a66c>();
    }

    public void _0x00bca0cc(int _0x1687ec53)
    {
        if (_0x1687ec53 == _0xecae2237.SPLASH && _0xfc90c1ec.Instance._0xcd9014e9 != _0x48063541.SCENE_0)
            _0x8f9b1458.Instance._0xf610bfa9();
        if (_0xfc90c1ec.Instance._0xcd9014e9 != _0x48063541.SCENE_0)
        {
            if (_0x1687ec53 == _0xecae2237.SPLASH || _0x1687ec53 == _0xecae2237.TUTORIAL0)
                _0xfc90c1ec.Instance._0x6026dd4a(false);
            else if (_0x1687ec53 == _0xecae2237.DEFAULT)
                _0xfc90c1ec.Instance._0x6026dd4a(true);
        }
    }

    private void SwitchSplash()
    {
        if (_0xa1ead1db.Instance.IsTutorialEnabled && !_0xfc90c1ec._0x336f8966._0xd2ad42b9)
            this._0x38a32e83(_0xecae2237.TUTORIAL0);
        else
            this._0x38a32e83(_0xecae2237.DEFAULT);
    }

    public void _0x38a32e83(int _0x2323c3fb)
    {
        this._0xc6ce5ec0(_0x2323c3fb);
        this._0x43d6919e(_0x2323c3fb);
        this.CurrentPanelIndex = _0x2323c3fb;
        this.Panels[_0x2323c3fb].Show();
    }
}