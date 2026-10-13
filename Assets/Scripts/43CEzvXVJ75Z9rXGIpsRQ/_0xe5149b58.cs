using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// Dresses WIN (7), LOSE (8) and PAUSE (6) completely, not just their three text fields.
///
/// Nothing here is addressed by name. The pops arrive from the template controller by
/// SETTINGS.POPS index, and the buttons inside them are told apart STRUCTURALLY: the
/// action buttons all share one parent and are the largest such group, so whatever is left
/// over is the close cross. Traversal order would hand back the cross first, which is how
/// a pause screen once ended up with three buttons all captioned RESUME (rule C.17).
///
/// The cross is also where the template's most visible defect lives: its icon Image has
/// preserveAspect on and NO sprite assigned, which Unity draws as a solid white square.
/// That same pair of properties is what identifies it here, and assigning _closeIcon is
/// what fixes it (rule B.1).
public sealed class _0xe5149b58 : MonoBehaviour
{
    public void _0x00ce9d49(_0x0250d15c _0x32db3c6e)
    {
        this._0x46d893a6 = _0x32db3c6e;
        _0xda9f334f _0x39cf7be5 = _0xda9f334f.Instance;
        if (_0x39cf7be5 == null)
        {
            return;
        }

        this._0x3ce30ffc = this._0xece2b344(_0x39cf7be5._0xd8443e1d(_0x47dc124a._0x4d40a7ba.WIN), this._winIcon, KindWin, _0x52b7392e._0x3157eb18(new byte[7] { 125, 111, 103, 98, 14, 97, 96 }, 46));
        this._0x4a2a868b = this._0xece2b344(_0x39cf7be5._0xd8443e1d(_0x47dc124a._0x4d40a7ba.LOSE), this._loseIcon, KindLose, _0x52b7392e._0x3157eb18(new byte[10] { 139, 132, 137, 129, 133, 232, 227, 253, 248, 248 }, 200));
        this._0x6fc26f60 = this._0xece2b344(_0x39cf7be5._0xd8443e1d(_0x47dc124a._0x4d40a7ba.PAUSE), this._pauseIcon, KindPause, _0x52b7392e._0x3157eb18(new byte[6] { 247, 224, 246, 240, 232, 224 }, 165));
        this._0x393f59d6(0, false);
        this._0xe4cc068f();
        this._0xd9bee2f2();
    }

    private void _0xd9bee2f2()
    {
        _0xda9f334f _0x1d5120fe = _0xda9f334f.Instance;
        if (_0x1d5120fe == null || this._0x46d893a6 == null)
        {
            return;
        }

        _0xf5115610 _0x0875f71c = this._0x46d893a6._0x46090d0c;
        string _0x460ea24d = _0x52b7392e._0x3157eb18(new byte[7] { 78, 84, 75, 70, 73, 67, 39 }, 7) + (_0x0875f71c._0x63540d22 + 1) + _0x52b7392e._0x3157eb18(new byte[4] { 118, 25, 16, 118 }, 86) + _0x728dc014.IslandCount + _0x52b7392e._0x3157eb18(new byte[3] { 21, 24, 21 }, 53) + _0x0875f71c._0xe32a8242 + _0x52b7392e._0x3157eb18(new byte[3] { 84, 91, 84 }, 116) + _0x728dc014.ChargesPerIsland + _0x52b7392e._0x3157eb18(new byte[8] { 63, 92, 87, 94, 77, 88, 90, 76 }, 31);
        this._0x43829bf5(_0x1d5120fe._0xd8443e1d(_0x47dc124a._0x4d40a7ba.PAUSE), _0x52b7392e._0x3157eb18(new byte[8] { 180, 187, 182, 189, 186, 167, 176, 177 }, 245), _0x52b7392e._0x3157eb18(new byte[30] { 181, 182, 175, 168, 181, 198, 167, 180, 163, 198, 160, 180, 163, 163, 198, 203, 198, 168, 169, 198, 180, 163, 167, 170, 198, 171, 169, 168, 163, 191 }, 230), _0x460ea24d);
        this._0x3b04cfbd(this._0x6fc26f60, this._pauseIcon);
    }

    private _0xa1cc5ca7 _0xece2b344(_0xa471e4fa _0x47e526bc, Sprite _0xf0d8591a, int _0x8eba90ad, string _0xc097bc7a)
    {
        if (_0x47e526bc == null || _0x47e526bc.Content == null)
        {
            return null;
        }

        Button[] _0x83069a57 = _0x47e526bc.Content.GetComponentsInChildren<Button>(true);
        List<Button> _0x7a916f9d = this._0x05c82a2d(_0x83069a57);
        for (int _0x4c37235d = 0; _0x4c37235d < _0x83069a57.Length; _0x4c37235d++)
        {
            if (!_0x7a916f9d.Contains(_0x83069a57[_0x4c37235d]))
            {
                this._0xe88560d6(_0x83069a57[_0x4c37235d]);
            }
        }

        Button _0x683c6dae = this._0x9e775e7c(_0x7a916f9d, 0, _0xc097bc7a, _0xa8208ec2.Turquoise);
        if (_0x683c6dae != null)
        {
            if (_0x8eba90ad == KindWin)
            {
                _0x683c6dae.onClick.AddListener(() => this._0x337f76de());
            }
            else if (_0x8eba90ad == KindLose)
            {
                _0x683c6dae.onClick.AddListener(() => this._0x315a7e54());
            }
            else
            {
                _0x683c6dae.onClick.AddListener(() => this._0x9649f210());
            }
        }

        Button _0x2d9c25b8 = this._0x9e775e7c(_0x7a916f9d, 1, _0x52b7392e._0x3157eb18(new byte[4] { 231, 239, 228, 255 }, 170), _0xa8208ec2.Fade(_0xa8208ec2.Raised, 0.9f));
        if (_0x2d9c25b8 != null)
        {
            _0x2d9c25b8.onClick.AddListener(() => this._0x1baae99f());
        }

        for (int _0x2ec90316 = 2; _0x2ec90316 < _0x7a916f9d.Count; _0x2ec90316++)
        {
            _0x7a916f9d[_0x2ec90316].gameObject.SetActive(false);
        }

        return this._0x794c30c6(_0x47e526bc, _0xf0d8591a);
    }

    public void _0x2b06bf69(int _0x0235218d, bool _0xb52925e1)
    {
        this._0x393f59d6(_0x0235218d, _0xb52925e1);
        _0xda9f334f _0x71709f42 = _0xda9f334f.Instance;
        if (_0x71709f42 != null)
        {
            _0x71709f42._0x5582d170(_0x47dc124a._0x4d40a7ba.WIN);
        }
    }

    [SerializeField]
    private Sprite _closeIcon;
    private const int KindPause = 2;
    /// Splits the pop's buttons into its two template groups without reading a name.
    /// BOT_BTNS holds the action buttons side by side under one parent; TOP_BTNS holds the
    /// close cross alone under its own. The biggest sibling group is therefore BOT_BTNS,
    /// and everything else is TOP_BTNS - which is what keeps a caption off the cross.
    private List<Button> _0x05c82a2d(Button[] _0x8c9a13a3)
    {
        Dictionary<Transform, List<Button>> _0x96920769 = new Dictionary<Transform, List<Button>>();
        for (int _0xb5dd168e = 0; _0xb5dd168e < _0x8c9a13a3.Length; _0xb5dd168e++)
        {
            Transform _0x065abb41 = _0x8c9a13a3[_0xb5dd168e].transform.parent;
            if (_0x065abb41 == null)
            {
                continue;
            }

            if (!_0x96920769.ContainsKey(_0x065abb41))
            {
                _0x96920769[_0x065abb41] = new List<Button>();
            }

            _0x96920769[_0x065abb41].Add(_0x8c9a13a3[_0xb5dd168e]);
        }

        List<Button> _0x64df5a09 = new List<Button>();
        foreach (KeyValuePair<Transform, List<Button>> _0xe2934903 in _0x96920769)
        {
            if (_0xe2934903.Value.Count > _0x64df5a09.Count)
            {
                _0x64df5a09 = _0xe2934903.Value;
            }
        }

        return _0x64df5a09;
    }

    private const int KindLose = 1;
    private void _0x337f76de()
    {
        _0xda9f334f _0x7d1c3df0 = _0xda9f334f.Instance;
        if (_0x7d1c3df0 != null)
        {
            _0x7d1c3df0._0x1a0587de();
        }

        if (this._0x46d893a6 != null)
        {
            this._0x46d893a6._0xee05c981();
        }
    }

    private _0xa1cc5ca7 _0x4a2a868b;
    private _0xa1cc5ca7 _0x3ce30ffc;
    private void _0xe4cc068f()
    {
        _0xda9f334f _0x79adfd96 = _0xda9f334f.Instance;
        if (_0x79adfd96 == null)
        {
            return;
        }

        this._0x43829bf5(_0x79adfd96._0xd8443e1d(_0x47dc124a._0x4d40a7ba.LOSE), _0x52b7392e._0x3157eb18(new byte[8] { 67, 64, 88, 47, 91, 70, 75, 74 }, 15), _0x52b7392e._0x3157eb18(new byte[24] { 136, 158, 132, 131, 241, 146, 158, 152, 159, 241, 129, 132, 131, 130, 148, 241, 152, 130, 241, 148, 156, 129, 133, 136 }, 209), _0x52b7392e._0x3157eb18(new byte[37] { 160, 181, 191, 177, 212, 181, 212, 178, 166, 177, 177, 212, 166, 177, 178, 189, 184, 184, 212, 217, 212, 189, 160, 212, 183, 187, 167, 160, 167, 212, 186, 187, 160, 188, 189, 186, 179 }, 244));
        this._0x3b04cfbd(this._0x4a2a868b, this._loseIcon);
    }

    private _0x0250d15c _0x46d893a6;
    private void _0x9649f210()
    {
        this._0xd9bee2f2();
        _0xda9f334f _0xe6cd1128 = _0xda9f334f.Instance;
        if (_0xe6cd1128 != null)
        {
            _0xe6cd1128._0x1a0587de();
        }
    }

    private void _0x3b04cfbd(_0xa1cc5ca7 _0x993e3e7f, Sprite _0xe19a383c)
    {
        if (_0x993e3e7f == null || this._0x46d893a6 == null)
        {
            return;
        }

        _0x6e94ba0e _0xc6132896 = this._0x46d893a6._0x38ac25cb;
        _0x993e3e7f._0xd5820692(_0xe19a383c, _0x52b7392e._0x3157eb18(new byte[5] { 225, 226, 251, 252, 225 }, 178), _0x3b25dc9b.Grouped(_0xc6132896._0x8c2a2200), _0x52b7392e._0x3157eb18(new byte[8] { 48, 55, 33, 38, 82, 37, 59, 60 }, 114), _0x3b25dc9b.Grouped(_0xc6132896._0x4f69350e));
    }

    private void _0x315a7e54()
    {
        if (this._0x46d893a6 != null)
        {
            this._0x46d893a6._0x1c0df634();
        }

        _0xda9f334f _0x1d1f725b = _0xda9f334f.Instance;
        if (_0x1d1f725b != null)
        {
            _0x1d1f725b._0x1a0587de();
        }
    }

    [SerializeField]
    private Sprite _winIcon;
    /// The metric strip goes directly under the pop's own body text, measured from that
    /// text's rect rather than guessed, so it cannot land on top of it.
    private _0xa1cc5ca7 _0x794c30c6(_0xa471e4fa _0x40d38db4, Sprite _0xc0dfbbae)
    {
        if (this._popCardPrefab == null || _0x40d38db4.ContentMainText == null)
        {
            return null;
        }

        RectTransform _0x89f8778e = _0x40d38db4.ContentMainText.rectTransform;
        RectTransform _0xcbc68c95 = _0x89f8778e.parent as RectTransform;
        if (_0xcbc68c95 == null)
        {
            return null;
        }

        _0xa1cc5ca7 _0x6032d473 = Instantiate(this._popCardPrefab, _0xcbc68c95);
        RectTransform _0x08dc95e5 = _0x6032d473.transform as RectTransform;
        if (_0x08dc95e5 != null)
        {
            _0x08dc95e5.anchorMin = _0x89f8778e.anchorMin;
            _0x08dc95e5.anchorMax = _0x89f8778e.anchorMax;
            _0x08dc95e5.pivot = _0x89f8778e.pivot;
            _0x08dc95e5.localScale = Vector3.one;
            float _0x91e4be87 = (_0x89f8778e.sizeDelta.y * 0.5f) + (_0x08dc95e5.sizeDelta.y * 0.5f) + 24f;
            _0x08dc95e5.anchoredPosition = new Vector2(_0x89f8778e.anchoredPosition.x, _0x89f8778e.anchoredPosition.y - _0x91e4be87);
        }

        _0x6032d473._0xd5820692(_0xc0dfbbae, _0x52b7392e._0x3157eb18(new byte[5] { 140, 143, 150, 145, 140 }, 223), _0x52b7392e._0x3157eb18(new byte[1] { 70 }, 118), _0x52b7392e._0x3157eb18(new byte[8] { 178, 181, 163, 164, 208, 167, 185, 190 }, 240), _0x52b7392e._0x3157eb18(new byte[1] { 237 }, 221));
        return _0x6032d473;
    }

    private const int KindWin = 0;
    private void _0x393f59d6(int _0x78942fab, bool _0x8ae505aa)
    {
        _0xda9f334f _0xe16d97ff = _0xda9f334f.Instance;
        if (_0xe16d97ff == null || this._0x46d893a6 == null)
        {
            return;
        }

        _0xf5115610 _0xdf796f62 = this._0x46d893a6._0x46090d0c;
        _0x728dc014 _0x2eddb837 = _0xdf796f62._0x53e3d196;
        int _0xd51bf2a7 = _0x2eddb837._0x196c0661(_0xdf796f62._0x63540d22 - 1);
        string _0x83bdca6a = _0x2eddb837._0xce8cbce1(_0xd51bf2a7) + _0x52b7392e._0x3157eb18(new byte[4] { 168, 165, 168, 163 }, 136) + _0x3b25dc9b.Grouped(_0x78942fab) + _0x52b7392e._0x3157eb18(new byte[6] { 215, 180, 184, 190, 185, 164 }, 247);
        string _0x33fc1ad3 = _0x8ae505aa ? _0x52b7392e._0x3157eb18(new byte[38] { 110, 125, 108, 103, 102, 127, 106, 99, 110, 104, 96, 15, 108, 99, 106, 110, 125, 106, 107, 15, 2, 15, 124, 110, 102, 99, 102, 97, 104, 15, 109, 110, 108, 100, 15, 123, 96, 15 }, 47) + _0x2eddb837._0xce8cbce1(0) : _0x52b7392e._0x3157eb18(new byte[11] { 133, 142, 147, 159, 235, 152, 159, 132, 155, 241, 235 }, 203) + _0x2eddb837._0xce8cbce1(_0xdf796f62._0x63540d22);
        this._0x43829bf5(_0xe16d97ff._0xd8443e1d(_0x47dc124a._0x4d40a7ba.WIN), _0x52b7392e._0x3157eb18(new byte[14] { 35, 57, 38, 43, 36, 46, 74, 41, 38, 43, 35, 39, 47, 46 }, 106), _0x83bdca6a, _0x33fc1ad3);
        this._0x3b04cfbd(this._0x3ce30ffc, this._winIcon);
    }

    [SerializeField]
    private _0xa1cc5ca7 _popCardPrefab;
    [SerializeField]
    private Sprite _pauseIcon;
    /// The cross keeps no caption and gets a real icon. Everything else about it is left
    /// to the template, including the close handler already on its own driver.
    private void _0xe88560d6(Button _0xc190df09)
    {
        TMP_Text[] _0x6b5e00d1 = _0xc190df09.GetComponentsInChildren<TMP_Text>(true);
        for (int _0x0e1a52f3 = 0; _0x0e1a52f3 < _0x6b5e00d1.Length; _0x0e1a52f3++)
        {
            _0x6b5e00d1[_0x0e1a52f3].text = string.Empty;
        }

        Image[] _0xc9ed93e6 = _0xc190df09.GetComponentsInChildren<Image>(true);
        for (int _0x81203eaf = 0; _0x81203eaf < _0xc9ed93e6.Length; _0x81203eaf++)
        {
            if (_0xc9ed93e6[_0x81203eaf].sprite == null && _0xc9ed93e6[_0x81203eaf].preserveAspect)
            {
                _0xc9ed93e6[_0x81203eaf].sprite = this._closeIcon;
                _0xc9ed93e6[_0x81203eaf].color = _0xa8208ec2.Cream;
                return;
            }
        }
    }

    public void _0x26acea2b()
    {
        this._0xe4cc068f();
        _0xda9f334f _0xcd60c2e1 = _0xda9f334f.Instance;
        if (_0xcd60c2e1 != null)
        {
            _0xcd60c2e1._0x5582d170(_0x47dc124a._0x4d40a7ba.LOSE);
        }
    }

    [SerializeField]
    private Sprite _loseIcon;
    private void _0x1baae99f()
    {
        if (_0xfc90c1ec.Instance != null)
        {
            _0xfc90c1ec.Instance._0xc04bfe9e(_0x47dc124a._0x48063541.SCENE_0);
        }
    }

    private Button _0x9e775e7c(List<Button> _0xd6457a18, int _0xb15630da, string _0xdfb96d31, Color _0x0cb8e762)
    {
        if (_0xb15630da >= _0xd6457a18.Count)
        {
            return null;
        }

        Button _0x7cb805bc = _0xd6457a18[_0xb15630da];
        _0x7cb805bc.gameObject.SetActive(true);
        TMP_Text[] _0xab1ce493 = _0x7cb805bc.GetComponentsInChildren<TMP_Text>(true);
        for (int _0x8620c7f9 = 0; _0x8620c7f9 < _0xab1ce493.Length; _0x8620c7f9++)
        {
            _0xab1ce493[_0x8620c7f9].color = _0xa8208ec2.Cream;
            _0xab1ce493[_0x8620c7f9].gameObject.SetActive(true);
            _0x3b25dc9b.SetText(_0xab1ce493[_0x8620c7f9], _0x8620c7f9 == 0 ? _0xdfb96d31 : string.Empty);
        }

        Image[] _0xecd5834d = _0x7cb805bc.GetComponentsInChildren<Image>(true);
        for (int _0x5e81df43 = 0; _0x5e81df43 < _0xecd5834d.Length; _0x5e81df43++)
        {
            if (_0xecd5834d[_0x5e81df43].sprite != null && _0xecd5834d[_0x5e81df43].type == Image.Type.Sliced)
            {
                _0xecd5834d[_0x5e81df43].color = _0x0cb8e762;
                break;
            }
        }

        return _0x7cb805bc;
    }

    private void _0x43829bf5(_0xa471e4fa _0xd45ba061, string _0x46801d00, string _0x2920bc18, string _0x307817ed)
    {
        if (_0xd45ba061 == null)
        {
            return;
        }

        if (_0xd45ba061.ContentHeaderText != null)
        {
            _0xd45ba061.ContentHeaderText.color = _0xa8208ec2.Sun;
            _0x3b25dc9b.SetText(_0xd45ba061.ContentHeaderText, _0x46801d00);
        }

        if (_0xd45ba061.ContentMainText != null)
        {
            _0xd45ba061.ContentMainText.color = _0xa8208ec2.Cream;
            _0x3b25dc9b.SetText(_0xd45ba061.ContentMainText, _0x2920bc18);
        }

        if (_0xd45ba061.ContentAdditionalText != null)
        {
            _0xd45ba061.ContentAdditionalText.color = _0xa8208ec2.Sky;
            _0x3b25dc9b.SetText(_0xd45ba061.ContentAdditionalText, _0x307817ed);
        }
    }

    private _0xa1cc5ca7 _0x6fc26f60;
}

internal static class _0x52b7392e
{
    internal static string _0x3157eb18(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}