using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0x5e6aef2d : MonoBehaviour
{
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    private void Start()
    {
        if (this.IsLoadCurrentScene)
            this.Button.onClick.AddListener(() =>
            {
                _0xfc90c1ec.Instance._0xc04bfe9e(SceneManager.GetActiveScene().buildIndex);
            });
        else
            this.Button.onClick.AddListener(() => _0xfc90c1ec.Instance._0xc04bfe9e(this.LoadSceneId));
    }

    public bool IsLoadCurrentScene;
    public Button Button;
    public int LoadSceneId;
}