using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0x8f9b1458 : MonoBehaviour
{
    public void _0x79552162()
    {
        this._0x4ec51c97?.Play();
    }

    public Slider AnimationSlider;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x8f9b1458>();
    }

    public void _0xe035cb79()
    {
        this._0x4ec51c97?.Kill();
        this.AnimationSlider.value = _0x7ba53f18 ? this.SecondPassSliderValue : 0.05f;
    }

    private static bool _0x7ba53f18 = false;
    public GameObject Error;
    public GameObject Content;
    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == _0x47dc124a._0x48063541.SCENE_0 && !_0x7ba53f18)
        {
            this._0x95d68e42();
        }
        else
        {
            this._0xf610bfa9();
        }
    }

    public float FirstAnimationTime = 10.0f;
    private Sequence _0x4ec51c97;
    public void _0xf91c891f()
    {
        {
#if B_LOGS
            {
                Debug.Log($"[Test] Animate Force");
            }
#endif
        }

        this._0x4ec51c97?.Kill();
        if (AnimationSlider != null)
            this.AnimationSlider.value = 1f;
        _0x7ba53f18 = false;
    }

    public float SecondPassSliderValue = 0.5f;
    public float DefaultAnimationTime = 0.4f;
    public GameObject Background;
    public void _0xf610bfa9()
    {
        this._0xe035cb79();
        bool _0x4f650808 = _0x7ba53f18;
        this._0x4ec51c97 = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0x1fc4f6ba => this.AnimationSlider.value = _0x1fc4f6ba, _0x4f650808 ? 1f : this.SecondPassSliderValue, this.DefaultAnimationTime)).SetEase(Ease.Linear);
        _0x7ba53f18 = !_0x7ba53f18;
    }

    public static _0x8f9b1458 Instance;
    public void _0xecd0e3db()
    {
        this._0x4ec51c97?.Pause();
    }

    private void _0x95d68e42()
    {
        this.AnimationSlider.value = 0.05f;
        _0x7ba53f18 = !_0x7ba53f18;
        this._0x4ec51c97 = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0x1fc4f6ba => this.AnimationSlider.value = _0x1fc4f6ba, 1f, this.FirstAnimationTime)).SetEase(Ease.Linear).OnComplete(() =>
        {
            _0x447218d1._0x69ef9ca0?._0xa467b12a();
        });
    }
}