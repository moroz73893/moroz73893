using TMPro;
using UnityEngine;

/// The eight awards plus the list of claimed islands. The island list CAN be empty, so it
/// renders a themed line instead of blank space - an empty area with no explanation is a
/// defect, not a layout.
public sealed class _0xd2e66206 : MonoBehaviour
{
    [SerializeField]
    private float _firstRowY = 600f;
    private _0xcb8a9174[] _0x549dfc27;
    [SerializeField]
    private TMP_Text _emptyLabel;
    [SerializeField]
    private float _rowPitch = 170f;
    public void _0x19b01960(_0x6e94ba0e _0xeef2cd69)
    {
        this._0xb74cfb75 = _0xeef2cd69;
        this._0xf704f570();
        this._0x6e19c506();
    }

    private readonly int[] _0xdb495957 = new int[]
    {
        1,
        50,
        500,
        10,
        5,
        1,
        3,
        7
    };
    private _0x6e94ba0e _0xb74cfb75;
    [SerializeField]
    private _0xcb8a9174 _rowPrefab;
    private void _0xf704f570()
    {
        if (this._rowHost == null || this._rowPrefab == null)
        {
            return;
        }

        this._0x549dfc27 = new _0xcb8a9174[RowCount];
        for (int _0x45e42de8 = 0; _0x45e42de8 < RowCount; _0x45e42de8++)
        {
            _0xcb8a9174 _0xeea84b34 = Instantiate(this._rowPrefab, this._rowHost);
            RectTransform _0xb10a586a = _0xeea84b34.transform as RectTransform;
            if (_0xb10a586a != null)
            {
                _0xb10a586a.anchoredPosition = new Vector2(0f, this._firstRowY - (_0x45e42de8 * this._rowPitch));
            }

            this._0x549dfc27[_0x45e42de8] = _0xeea84b34;
        }
    }

    private readonly string[] _0xa127d708 = new string[]
    {
        _0x91b4f388._0x15571726(new byte[10] { 186, 181, 174, 175, 168, 220, 175, 172, 181, 178 }, 252),
        _0x91b4f388._0x15571726(new byte[8] { 227, 230, 246, 133, 134, 159, 152, 133 }, 214),
        _0x91b4f388._0x15571726(new byte[9] { 113, 116, 116, 100, 23, 20, 13, 10, 23 }, 68),
        _0x91b4f388._0x15571726(new byte[14] { 35, 60, 41, 34, 76, 93, 92, 76, 47, 36, 41, 63, 56, 63 }, 108),
        _0x91b4f388._0x15571726(new byte[19] { 248, 247, 240, 250, 158, 139, 158, 248, 241, 236, 234, 235, 240, 251, 158, 245, 251, 231, 237 }, 190),
        _0x91b4f388._0x15571726(new byte[22] { 217, 212, 219, 209, 181, 193, 221, 208, 181, 223, 212, 214, 222, 197, 218, 193, 181, 194, 208, 209, 210, 208 }, 149),
        _0x91b4f388._0x15571726(new byte[15] { 157, 146, 159, 151, 147, 254, 237, 254, 151, 141, 146, 159, 144, 154, 141 }, 222),
        _0x91b4f388._0x15571726(new byte[12] { 238, 244, 157, 152, 128, 249, 138, 141, 139, 156, 152, 146 }, 217),
    };
    private void _0x9e8f6d61()
    {
        int _0x6d69d799 = this._0xb74cfb75._0xb63d08f8;
        bool _0x31af3768 = _0x6d69d799 <= 0;
        if (this._emptyLabel != null)
        {
            this._emptyLabel.gameObject.SetActive(_0x31af3768);
            this._emptyLabel.color = _0xa8208ec2.Muted;
            _0x3b25dc9b.SetText(this._emptyLabel, _0x91b4f388._0x15571726(new byte[55] { 98, 99, 12, 101, 127, 96, 109, 98, 104, 127, 12, 111, 96, 109, 101, 97, 105, 104, 12, 117, 105, 120, 38, 106, 101, 96, 96, 12, 109, 12, 111, 100, 109, 126, 107, 105, 12, 97, 105, 120, 105, 126, 12, 120, 99, 12, 111, 96, 109, 101, 97, 12, 99, 98, 105 }, 44));
        }

        if (this._islandsLabel == null)
        {
            return;
        }

        this._islandsLabel.gameObject.SetActive(!_0x31af3768);
        if (_0x31af3768)
        {
            return;
        }

        _0x728dc014 _0x8e50c21d = new _0x728dc014();
        System.Text.StringBuilder _0xab62e2c5 = new System.Text.StringBuilder();
        int _0x37b8af91 = _0x6d69d799 > _0x728dc014.IslandCount ? _0x728dc014.IslandCount : _0x6d69d799;
        for (int _0x64f760bb = 0; _0x64f760bb < _0x37b8af91; _0x64f760bb++)
        {
            if (_0x64f760bb > 0)
            {
                _0xab62e2c5.Append('\n');
            }

            _0xab62e2c5.Append(_0x8e50c21d._0xce8cbce1(_0x64f760bb));
        }

        this._islandsLabel.color = _0xa8208ec2.Sun;
        _0x3b25dc9b.SetText(this._islandsLabel, _0xab62e2c5.ToString());
    }

    public void _0x6e19c506()
    {
        if (this._0xb74cfb75 == null || this._0x549dfc27 == null)
        {
            return;
        }

        int[] _0xb5655c79 = new int[]
        {
            this._0xb74cfb75._0x8c2a2200,
            this._0xb74cfb75._0x8c2a2200,
            this._0xb74cfb75._0x8c2a2200,
            this._0xb74cfb75._0xfa787124,
            this._0xb74cfb75._0xd301b78c,
            this._0xb74cfb75._0x8a8d6ea6,
            this._0xb74cfb75._0xb63d08f8,
            this._0xb74cfb75._0x857ecc6b,
        };
        for (int _0x90f8e7dd = 0; _0x90f8e7dd < this._0x549dfc27.Length; _0x90f8e7dd++)
        {
            bool _0xd538d755 = _0xb5655c79[_0x90f8e7dd] >= this._0xdb495957[_0x90f8e7dd];
            this._0x549dfc27[_0x90f8e7dd]._0xbbc8453a(this._0xa127d708[_0x90f8e7dd], _0xb5655c79[_0x90f8e7dd], this._0xdb495957[_0x90f8e7dd], _0xd538d755);
        }

        this._0x9e8f6d61();
    }

    public const int RowCount = 8;
    [SerializeField]
    private RectTransform _rowHost;
    [SerializeField]
    private TMP_Text _islandsLabel;
}

internal static class _0x91b4f388
{
    internal static string _0x15571726(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}