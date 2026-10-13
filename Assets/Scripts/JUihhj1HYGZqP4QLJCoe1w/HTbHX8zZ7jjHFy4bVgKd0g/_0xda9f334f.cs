using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0x47dc124a;

public class _0xda9f334f : MonoBehaviour
{
    public int CurrentPopIndex;
    public List<_0xa471e4fa> Pops;
    private void _0x82ac534b()
    {
        this.Invoke(nameof(this.BackgroundHidden), this.ScaleDuration);
    }

    private void _0xc17ca2c1()
    {
        this.BlurBackground.gameObject.SetActive(true);
    }

    public float ScaleDuration = 0.4f;
    public void _0x2c5e6737()
    {
        this.LastPopIndexes.RemoveAll(_0xd3221b2e => _0xd3221b2e == this.CurrentPopIndex);
        if (this.LastPopIndexes.Count <= 0)
            this._0x1a0587de();
        else
            this._0x5582d170(this.LastPopIndexes.Last());
    }

    public static _0xda9f334f Instance;
    public List<int> LastPopIndexes = new();
    public void _0x5582d170(int _0x94f299c8)
    {
        this.CurrentPopIndex = _0x94f299c8;
        this.LastPopIndexes.Add(this.CurrentPopIndex);
        this._0x7af00256(true);
        this._0xc17ca2c1();
        this.Pops[_0x94f299c8].Show();
        foreach (GameObject _0xf39ced70 in this.GameObjectsToHide)
            _0xf39ced70.SetActive(false);
    }

    private void BackgroundHidden()
    {
        this.BlurBackground.gameObject.SetActive(false);
    }

    public GameObject BlurBackground;
    public List<GameObject> GameObjectsToHide;
    public _0xa471e4fa _0xd8443e1d(int _0x8eb54ac2)
    {
        return this.Pops[_0x8eb54ac2];
    }

    private void Start()
    {
        this.BackgroundHidden();
        foreach (_0xa471e4fa _0x29ac3ff3 in this.Pops)
            if (_0x29ac3ff3 != null)
                _0x29ac3ff3.gameObject.SetActive(true);
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0xda9f334f>();
    }

    public void _0x1a0587de()
    {
        this.LastPopIndexes.Clear();
        this._0x7af00256();
        foreach (GameObject _0x0bde2caf in this.GameObjectsToHide)
            if (_0x0bde2caf != null)
                _0x0bde2caf.SetActive(true);
        this._0x82ac534b();
    }

    private void _0x7af00256(bool _0x653a0a3c = false)
    {
        for (int _0x1f0c5a50 = 0; _0x1f0c5a50 < this.Pops.Count; ++_0x1f0c5a50)
            if (this.Pops[_0x1f0c5a50] != null && !(_0x1f0c5a50 == this.CurrentPopIndex && _0x653a0a3c))
                this.Pops[_0x1f0c5a50]._0x34f0d9ce();
    }
}