using TMPro;
using UnityEngine;

/// The template ships more panels than this game dresses, and every panel we did not dress
/// still carries its placeholder copy - "Lorem Ipsum", "HEADER". Rule C.15: the panels stay
/// in place, because the controller addresses them by index and a pulled-out object breaks
/// navigation; only their text is cleared.
///
/// The panels are reached through the template controller BY INDEX
/// (SETTINGS.PANELS.TUTORIAL0..TUTORIAL6), never by object name, so obfuscation has nothing
/// to break. The two panels this game does dress - SPLASH and DEFAULT - are never touched:
/// their captions are ours.
public sealed class _0xb80e368d : MonoBehaviour
{
    private void Start()
    {
        _0x6ae8a66c _0xc50bcbfe = _0x6ae8a66c.Instance;
        if (_0xc50bcbfe == null || _0xc50bcbfe.Panels == null)
        {
            return;
        }

        int[] _0xb4c437fb = new int[]
        {
            _0x47dc124a._0xecae2237.TUTORIAL0,
            _0x47dc124a._0xecae2237.TUTORIAL1,
            _0x47dc124a._0xecae2237.TUTORIAL2,
            _0x47dc124a._0xecae2237.TUTORIAL3,
            _0x47dc124a._0xecae2237.TUTORIAL4,
            _0x47dc124a._0xecae2237.TUTORIAL5,
            _0x47dc124a._0xecae2237.TUTORIAL6,
        };
        for (int _0x708864bd = 0; _0x708864bd < _0xb4c437fb.Length; _0x708864bd++)
        {
            int _0x317ce95a = _0xb4c437fb[_0x708864bd];
            if (_0x317ce95a < 0 || _0x317ce95a >= _0xc50bcbfe.Panels.Count)
            {
                continue;
            }

            _0x8ae4c95e _0xf61670bb = _0xc50bcbfe.Panels[_0x317ce95a];
            if (_0xf61670bb == null)
            {
                continue;
            }

            TMP_Text[] _0x22dd3f6e = _0xf61670bb.GetComponentsInChildren<TMP_Text>(true);
            for (int _0x2ffe7921 = 0; _0x2ffe7921 < _0x22dd3f6e.Length; _0x2ffe7921++)
            {
                _0x22dd3f6e[_0x2ffe7921].text = string.Empty;
            }
        }
    }
}