using UnityEngine;
using UnityEngine.UI;

public class _0x50e9b46b : MonoBehaviour
{
    public int NextTutorialPanelIndex;
    public int EndTutorialPanelIndex = 1;
    public bool IsTutorialEndPanel;
    public Button TutorialEndButton;
    public Button NextTutorialButton;
    private void Start()
    {
        if (this.NextTutorialButton != null)
        {
            if (this.IsTutorialEndPanel)
            {
                this.NextTutorialButton.onClick.AddListener(() => _0x6ae8a66c.Instance._0x38a32e83(this.EndTutorialPanelIndex));
                this.NextTutorialButton.onClick.AddListener(() => _0xfc90c1ec.Instance._0xd02e8da7());
            }
            else
            {
                this.NextTutorialButton.onClick.AddListener(() => _0x6ae8a66c.Instance._0x38a32e83(this.NextTutorialPanelIndex));
            }
        }

        if (this.TutorialEndButton != null)
        {
            this.TutorialEndButton.onClick.AddListener(() => _0x6ae8a66c.Instance._0x38a32e83(this.EndTutorialPanelIndex));
            this.TutorialEndButton.onClick.AddListener(() => _0xfc90c1ec.Instance._0xd02e8da7());
        }
    }
}