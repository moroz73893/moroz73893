using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class _0xfc35b2f8 : MonoBehaviour
{
    private float _0xf8539e5f = 0.6f;
    private float _0xfc4a0ef9 = 1.5f;
    private void Update()
    {
        int _0x1de39eda = 1;
        if (this._0xee915d05.Count > 0)
        {
            string _0xccbe5efd = this._0x6aec8cc1.text;
            foreach (string _0x988f7eb1 in this._0xee915d05)
                while (_0xccbe5efd.Contains(_0x988f7eb1))
                    _0xccbe5efd = _0xccbe5efd.Replace(_0x988f7eb1, "");
            _0x1de39eda = _0xccbe5efd.Length;
        }
        else
        {
            _0x1de39eda = this._0x6aec8cc1.text.Length;
        }

        float _0x3334001a = Mathf.Clamp(this._0xd8b63671 + this._0xf8539e5f * _0x1de39eda, this._0xfc4a0ef9, this._0x24e1db58);
        if (!Mathf.Approximately(this._0x6f79543b.aspectRatio, _0x3334001a))
            this._0x6f79543b.aspectRatio = _0x3334001a;
    }

    private TMP_Text _0x6aec8cc1;
    private AspectRatioFitter _0x6f79543b;
    private List<string> _0xee915d05 = new();
    private float _0xd8b63671;
    private float _0x24e1db58 = 4;
}