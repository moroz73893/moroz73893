using UnityEngine;
using UnityEngine.UI;

public class _0x394c6be5 : MonoBehaviour
{
    private void Start()
    {
        this.Button.onClick.AddListener(() => _0xfc90c1ec.Instance._0x6026dd4a(this.IsPhysicsRunOnClick));
    }

    public bool IsPhysicsRunOnClick;
    public Button Button;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }
}