using UnityEngine;
using UnityEngine.UI;

public class _0xc6afdcd6 : MonoBehaviour
{
    private void Start()
    {
        if (this._0xa420881d)
            this._0x6c593a07.onClick.AddListener(() => _0x6ae8a66c.Instance._0xf037c388());
        else
            this._0x6c593a07.onClick.AddListener(() => _0x6ae8a66c.Instance._0x38a32e83(this._0x272b10f9));
    }

    private bool _0xa420881d;
    private void Awake()
    {
        if (this._0x6c593a07 == null)
            if (!this.TryGetComponent(out this._0x6c593a07))
                this._0x6c593a07 = this.GetComponentInChildren<Button>();
    }

    private int _0x272b10f9;
    private Button _0x6c593a07;
}