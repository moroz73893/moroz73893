/// Lays the twelve wedges around the circle in a NEW order every session, so two
/// sessions never show the same wheel. The angles and payouts are fixed; only their
/// placement is generated, which is exactly what rule C.11 asks for.
///
/// Constraints, all checked on the circle (last wedge is adjacent to the first):
///   * the three 6-degree gold wedges stay together as one block - that is the GOLD BAND,
///     and it has to read as a deliberate band rather than three stray slivers;
///   * the two 62-degree COCONUT duds are never adjacent;
///   * TREASURE is never adjacent to BONUS SPIN.
/// Generate, test, retry up to 20 times, then fall back to the authored order. The
/// fallback exists only as a fallback, never as the game.
public sealed class _0xbacdda19
{
    public _0x0435f2a6[] _0x2782c20e(_0xaecf408d _0xc05c27fe)
    {
        _0x0435f2a6[] _0x03c5228f = new _0x18daa9a8()._0x44f80fbe();
        this._0x88d250fe = false;
        for (int _0x9205d4c2 = 0; _0x9205d4c2 < MaxAttempts; _0x9205d4c2++)
        {
            _0x0435f2a6[] _0xa6260bd4 = this._0x4984760a(_0x03c5228f, _0xc05c27fe);
            if (this._0x912e7d0b(_0xa6260bd4))
            {
                this._0xf317639e(_0xa6260bd4);
                return _0xa6260bd4;
            }
        }

        this._0x88d250fe = true;
        _0x0435f2a6[] _0x3dffee8d = this._0xc923ac54(_0x03c5228f);
        this._0xf317639e(_0x3dffee8d);
        return _0x3dffee8d;
    }

    public const int MaxAttempts = 20;
    /// A stable signature of a layout, used by the harness to count distinct wheels.
    public string _0xa1f0fc83(_0x0435f2a6[] _0xf4be674b)
    {
        System.Text.StringBuilder _0xced80fcd = new System.Text.StringBuilder();
        for (int _0xcaa2b29b = 0; _0xcaa2b29b < _0xf4be674b.Length; _0xcaa2b29b++)
        {
            _0xced80fcd.Append(_0xf4be674b[_0xcaa2b29b].Label);
            _0xced80fcd.Append('|');
        }

        return _0xced80fcd.ToString();
    }

    /// One shuffle. The gold band travels as a single unit so it cannot be split.
    private _0x0435f2a6[] _0x4984760a(_0x0435f2a6[] _0x8224b582, _0xaecf408d _0xecb5d37d)
    {
        _0x0435f2a6[] _0xf1cdc3b6 = new _0x0435f2a6[3];
        _0x0435f2a6[] _0x3caf524d = new _0x0435f2a6[_0x8224b582.Length - 3];
        int _0x02773427 = 0;
        int _0xf6cabcab = 0;
        for (int _0xb4f03c8f = 0; _0xb4f03c8f < _0x8224b582.Length; _0xb4f03c8f++)
        {
            if (_0x8224b582[_0xb4f03c8f].IsGoldBand)
            {
                _0xf1cdc3b6[_0x02773427++] = _0x8224b582[_0xb4f03c8f]._0x45724856();
            }
            else
            {
                _0x3caf524d[_0xf6cabcab++] = _0x8224b582[_0xb4f03c8f]._0x45724856();
            }
        }

        _0xecb5d37d._0x73567695(_0xf1cdc3b6);
        _0xecb5d37d._0x73567695(_0x3caf524d);
        // The band occupies one of the 10 unit slots; pick which one.
        int _0x05a94375 = _0xecb5d37d._0x472c4a41(_0x3caf524d.Length + 1);
        _0x0435f2a6[] _0x27f55a54 = new _0x0435f2a6[_0x8224b582.Length];
        int _0x8d8f1a50 = 0;
        for (int _0xb8eacd4e = 0; _0xb8eacd4e < _0x3caf524d.Length + 1; _0xb8eacd4e++)
        {
            if (_0xb8eacd4e == _0x05a94375)
            {
                for (int _0x420732e6 = 0; _0x420732e6 < _0xf1cdc3b6.Length; _0x420732e6++)
                {
                    _0x27f55a54[_0x8d8f1a50++] = _0xf1cdc3b6[_0x420732e6];
                }
            }

            if (_0xb8eacd4e < _0x3caf524d.Length)
            {
                _0x27f55a54[_0x8d8f1a50++] = _0x3caf524d[_0xb8eacd4e];
            }
        }

        return _0x27f55a54;
    }

    /// The authored order rotated so the band is not at 0 degrees; it satisfies every
    /// constraint by construction and is only ever reached when 20 shuffles failed.
    private _0x0435f2a6[] _0xc923ac54(_0x0435f2a6[] _0x4dbd273d)
    {
        int[] _0x5a85a6a5 = new int[]
        {
            0,
            1,
            10,
            2,
            7,
            8,
            9,
            4,
            5,
            3,
            6,
            11
        };
        _0x0435f2a6[] _0xcf73ed17 = new _0x0435f2a6[_0x5a85a6a5.Length];
        for (int _0x6a3e57a1 = 0; _0x6a3e57a1 < _0x5a85a6a5.Length; _0x6a3e57a1++)
        {
            _0xcf73ed17[_0x6a3e57a1] = _0x4dbd273d[_0x5a85a6a5[_0x6a3e57a1]]._0x45724856();
        }

        return _0xcf73ed17;
    }

    /// Start angles run clockwise from the top (12 o'clock), which is where the pointer is.
    public void _0xf317639e(_0x0435f2a6[] _0x1914c58f)
    {
        int _0x9715db10 = 0;
        for (int _0x6d11df37 = 0; _0x6d11df37 < _0x1914c58f.Length; _0x6d11df37++)
        {
            _0x1914c58f[_0x6d11df37].StartAngle = _0x9715db10;
            _0x9715db10 += _0x1914c58f[_0x6d11df37].Angle;
        }
    }

    private bool _0x88d250fe;
    public bool _0x7a7a636b
    {
        get
        {
            return this._0x88d250fe;
        }
    }

    public bool _0x912e7d0b(_0x0435f2a6[] _0x941fd280)
    {
        if (_0x941fd280 == null || _0x941fd280.Length != _0x18daa9a8.SectorCount)
        {
            return false;
        }

        int _0xa486f62d = -1;
        int _0xebbc37b0 = 0;
        for (int _0xbb0a2236 = 0; _0xbb0a2236 < _0x941fd280.Length; _0xbb0a2236++)
        {
            if (_0x941fd280[_0xbb0a2236].IsGoldBand)
            {
                _0xebbc37b0++;
                if (_0xa486f62d < 0)
                {
                    _0xa486f62d = _0xbb0a2236;
                }
            }
        }

        if (_0xebbc37b0 != 3)
        {
            return false;
        }

        for (int _0x2cb17d9c = 0; _0x2cb17d9c < 3; _0x2cb17d9c++)
        {
            if (!_0x941fd280[(_0xa486f62d + _0x2cb17d9c) % _0x941fd280.Length].IsGoldBand)
            {
                return false;
            }
        }

        for (int _0x4a79400c = 0; _0x4a79400c < _0x941fd280.Length; _0x4a79400c++)
        {
            _0x0435f2a6 _0x8d95ee1b = _0x941fd280[_0x4a79400c];
            _0x0435f2a6 _0x3bdcb871 = _0x941fd280[(_0x4a79400c + 1) % _0x941fd280.Length];
            if (_0x8d95ee1b.Kind == _0xf64f5669.Dud && _0x3bdcb871.Kind == _0xf64f5669.Dud)
            {
                return false;
            }

            bool _0xbbec4a19 = (_0x8d95ee1b.Kind == _0xf64f5669.Treasure && _0x3bdcb871.Kind == _0xf64f5669.BonusSpin) || (_0x8d95ee1b.Kind == _0xf64f5669.BonusSpin && _0x3bdcb871.Kind == _0xf64f5669.Treasure);
            if (_0xbbec4a19)
            {
                return false;
            }
        }

        return true;
    }
}