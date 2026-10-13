using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static _0x47dc124a;

public class _0xfc90c1ec : MonoBehaviour
{
    private IEnumerator _0x17fae704(string _0x93dfe185)
    {
        _0x6ae8a66c.Instance._0x38a32e83(_0xecae2237.SPLASH);
        //AudioController.Instance.SaveLastMusicTimes();
        AsyncOperation _0x9bd8d0b1 = SceneManager.LoadSceneAsync(_0x93dfe185);
        while (!_0x9bd8d0b1.isDone)
            yield return null;
    }

    public void _0x4bb1347c()
    {
        this._0xc04bfe9e(SceneManager.GetActiveScene().buildIndex);
    }

    public Button DeleteProgressDataButton;
    public static _0xfc90c1ec Instance;
    public bool _0x445fd59a { get; private set; }

    public void _0xd02e8da7()
    {
        _0x336f8966._0xd2ad42b9 = true;
    }

    public static bool IsAfterLevelFailed = false;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0xfc90c1ec>();
        this.RootGameObject = GameObject.FindWithTag(_0x3514d35c._0x8eb0eac2(new byte[4] { 162, 159, 159, 132 }, 240));
        if (this._0xcd9014e9 == _0x48063541.SCENE_0)
            this._0x6026dd4a(true);
        else
            this._0x6026dd4a(false);
        this.MoneyCountContainers = this.RootGameObject.GetComponentsInChildren<_0x41fb5d86>(true).ToList();
    }

    public void _0xc04bfe9e(int _0x40b7fee0)
    {
        //if (SceneManager.GetActiveScene().buildIndex == sceneIndex)
        //    AdsInitializer.Instance?.ShowAd();
        this.StartCoroutine(this._0x746182fa(_0x40b7fee0));
    }

    private void _0x7ca77577(Transform _0x2db0590b)
    {
        Transform[] _0xfb2d63eb = _0x2db0590b.GetComponentsInChildren<Transform>();
        foreach (Transform _0x29003b4a in _0xfb2d63eb)
            if (_0x29003b4a != null && DOTween.IsTweening(_0x29003b4a))
            {
                if (this._0x445fd59a)
                    DOTween.Play(_0x29003b4a);
                else
                    DOTween.Pause(_0x29003b4a);
            }
    }

    private static void ExitGame()
    {
        Application.Quit();
    }

    public Canvas MainCanvas;
    public Button ShowResetTutorialButton;
    public void _0x6026dd4a(bool _0x957c2dcf)
    {
        this._0x445fd59a = _0x957c2dcf;
        this._0xdef5ee9b(!this._0x445fd59a);
        Physics2D.simulationMode = this._0x445fd59a ? SimulationMode2D.FixedUpdate : SimulationMode2D.Script;
        if (this.EnvironmentWithTweensToToggle != null)
            this._0x7ca77577(this.EnvironmentWithTweensToToggle);
    }

    public void _0x58c2b860()
    {
        foreach (_0x41fb5d86 _0xdd46706b in this.MoneyCountContainers)
            _0xdd46706b._0x9dbe0113();
    }

    public static bool IsAfterLevelComplete;
    private void _0xcbf6788b()
    {
        IsAfterLevelComplete = true;
        Instance._0xc04bfe9e(_0x48063541.SCENE_0);
    }

    private static _0xf09d5d02 _0xed19af93 => _0xf09d5d02.ALL_SCENES_SETTING_SINGLETONS[0];

    private void _0xdef5ee9b(bool _0x35d9cdfa)
    {
        Rigidbody2D[] _0xf660672d = this.RootGameObject.GetComponentsInChildren<Rigidbody2D>(true);
        foreach (Rigidbody2D _0x88f8d0e0 in _0xf660672d)
            if (_0x35d9cdfa)
                _0x88f8d0e0.constraints = RigidbodyConstraints2D.FreezeAll;
            else
                _0x88f8d0e0.constraints = RigidbodyConstraints2D.None;
    }

    public int _0xcd9014e9 => SceneManager.GetActiveScene().buildIndex;

    public Transform Environment;
    private void Start()
    {
        if (this._0xcd9014e9 != _0x48063541.SCENE_0)
            Screen.orientation = ScreenOrientation.Portrait;
        this.DeleteProgressDataButton?.onClick.AddListener(() =>
        {
            PlayerPrefs.DeleteAll();
            //AudioController.Instance.UpdateMusics();
            //AudioController.Instance.UpdateSfxes();
            Instance._0xc04bfe9e(_0x48063541.SCENE_0);
        });
        this.ShowResetTutorialButton?.onClick.AddListener(() =>
        {
            _0x336f8966._0xd2ad42b9 = false;
            _0xda9f334f.Instance._0x1a0587de();
            _0x6ae8a66c.Instance._0x38a32e83(_0xecae2237.TUTORIAL0);
        });
    }

    public static _0xf09d5d02 _0x336f8966 => _0xf09d5d02.ALL_SCENES_SETTING_SINGLETONS[Instance._0xcd9014e9];

    [HideInInspector]
    public GameObject RootGameObject; // tag - "Root"
    private IEnumerator _0x746182fa(int _0x413288a6)
    {
        _0x6ae8a66c.Instance._0x38a32e83(_0xecae2237.SPLASH);
        AsyncOperation _0x907688ee = SceneManager.LoadSceneAsync(_0x413288a6);
        while (!_0x907688ee.isDone)
            yield return null;
    }

    private static void MakeGrid(List<RectTransform> _0xb1882f29, AspectRatioFitter _0x12f6e2e6, float _0x3269515a, int _0x3114e106, int _0xde5f9920)
    {
        _0x12f6e2e6.aspectMode = AspectRatioFitter.AspectMode.WidthControlsHeight;
        _0x12f6e2e6.aspectRatio = _0x3269515a;
        foreach (RectTransform _0xfeb339e5 in _0xb1882f29)
        {
            int _0xa8ed36f3 = _0xfeb339e5.transform.GetSiblingIndex();
            _0xfeb339e5.anchorMin = new Vector3(Mathf.FloorToInt((float)_0xa8ed36f3 % _0x3114e106) * (1f / _0x3114e106), (_0xde5f9920 - (Mathf.FloorToInt((float)_0xa8ed36f3 / _0x3114e106) % _0xde5f9920 + 1f)) * (1f / _0xde5f9920));
            _0xfeb339e5.anchorMax = new Vector3(Mathf.FloorToInt((float)_0xa8ed36f3 % _0x3114e106 + 1f) * (1f / _0x3114e106), (_0xde5f9920 - Mathf.FloorToInt((float)_0xa8ed36f3 / _0x3114e106) % _0xde5f9920) * (1f / _0xde5f9920));
            _0xfeb339e5.offsetMin = Vector2.zero;
            _0xfeb339e5.offsetMax = Vector2.zero;
        }
    }

    [HideInInspector]
    public List<_0x41fb5d86> MoneyCountContainers = new();
    public Transform EnvironmentWithTweensToToggle;
    private static _0xf09d5d02 GAME_INDEX_SETTINGS(int _0x5b6d7b6e)
    {
        return _0xf09d5d02.ALL_SCENES_SETTING_SINGLETONS[_0x5b6d7b6e];
    }
}

internal static class _0x3514d35c
{
    internal static string _0x8eb0eac2(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}