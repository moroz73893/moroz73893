using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x6c5e187d : MonoBehaviour
{
    private Image _0xec3f706a;
    private void _0x5b1b94ab()
    {
        if (this._0xec3f706a.canvasRenderer.GetColor() != this._0x26ad9ebc.canvasRenderer.GetColor())
            this._0x26ad9ebc.canvasRenderer.SetColor(this._0xec3f706a.canvasRenderer.GetColor());
    }

    private void Update()
    {
        this._0x5b1b94ab();
    }

    private TMP_Text _0x26ad9ebc;
}