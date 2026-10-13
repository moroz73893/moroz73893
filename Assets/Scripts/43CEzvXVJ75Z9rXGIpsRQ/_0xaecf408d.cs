/// One System.Random per session, seeded deterministically from the island and the
/// session counter. UnityEngine.Random is deliberately not used: it is global state, so
/// two systems pulling on it stop being reproducible from a seed.
public sealed class _0xaecf408d
{
    private readonly int _0x1142c289;
    public int _0x44928f04
    {
        get
        {
            return this._0x1142c289;
        }
    }

    public double _0x1f8f3d5b()
    {
        return this._0x5c446d9f.NextDouble();
    }

    public int _0x472c4a41(int _0x31c89f89)
    {
        if (_0x31c89f89 <= 0)
        {
            return 0;
        }

        return this._0x5c446d9f.Next(_0x31c89f89);
    }

    /// Fisher-Yates, in place, on the caller's array.
    public void _0x73567695<T>(T[] _0xfa23650d)
    {
        if (_0xfa23650d == null)
        {
            return;
        }

        for (int _0x75775bbb = _0xfa23650d.Length - 1; _0x75775bbb > 0; _0x75775bbb--)
        {
            int _0x6885ac70 = this._0x5c446d9f.Next(_0x75775bbb + 1);
            T _0xdeb1384d = _0xfa23650d[_0x75775bbb];
            _0xfa23650d[_0x75775bbb] = _0xfa23650d[_0x6885ac70];
            _0xfa23650d[_0x6885ac70] = _0xdeb1384d;
        }
    }

    public _0xaecf408d(int _0x7c6266c5, int _0x0622e3cb)
    {
        this._0x1142c289 = (_0x7c6266c5 * 7919) ^ (_0x0622e3cb * 104729);
        this._0x5c446d9f = new System.Random(this._0x1142c289);
    }

    private readonly System.Random _0x5c446d9f;
    public int _0x6150b921(int _0x4ad8bf41, int _0xab477547)
    {
        if (_0xab477547 <= _0x4ad8bf41)
        {
            return _0x4ad8bf41;
        }

        return this._0x5c446d9f.Next(_0x4ad8bf41, _0xab477547);
    }
}