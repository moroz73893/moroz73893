using UnityEngine;
using UnityEngine.UI;

public class _0x72c23fc3 : MonoBehaviour
{
    private void Start()
    {
        if (this.IsShowLastPop)
            this.Button.onClick.AddListener(() =>
            {
                _0xda9f334f.Instance._0x2c5e6737();
            });
        else if (this.IsHideAllPops)
            this.Button.onClick.AddListener(() => _0xda9f334f.Instance._0x1a0587de());
        else
            this.Button.onClick.AddListener(() => _0xda9f334f.Instance._0x5582d170(this.PopToShowIndex));
    }

    public bool IsHideAllPops;
    public int PopToShowIndex;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public bool IsShowLastPop;
    public Button Button;
}