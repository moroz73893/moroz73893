using TMPro;
using UnityEngine;
using static _0x47dc124a;

public class _0x41fb5d86 : MonoBehaviour
{
    public TMP_Text MoneyCountText;
    private void Start()
    {
        if (this.MoneyCountText == null)
        {
            TMP_Text _0xc91e2258;
            if (this.gameObject.TryGetComponent(out _0xc91e2258))
                this.MoneyCountText = _0xc91e2258;
        }

        this._0x9dbe0113();
    }

    public void _0x9dbe0113()
    {
        this.MoneyCountText.text = _0xd6107ecd._0xdfb099ed.ToString();
    }
}