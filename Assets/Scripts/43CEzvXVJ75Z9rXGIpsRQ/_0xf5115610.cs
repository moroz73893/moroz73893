/// The whole rules layer of one play session: the wheel order, the purse, the bet, the
/// Fortune Meter and the island. It names no UnityEngine type on purpose, so the same
/// code that ships can be compiled and fuzzed headlessly.
///
/// Rule C.5 is satisfied BY CONSTRUCTION: there is no timer, no draining meter, and the
/// balance changes only inside Spin(), which nothing but a tap calls. A run with zero
/// taps is therefore unbounded.
public sealed class _0xf5115610
{
    public void _0xa24e1784(int _0x083276af)
    {
        if (_0x083276af < 0 || _0x083276af >= this._0x06aa3a1c.Length)
        {
            return;
        }

        this._0xbe8b5f28 = _0x083276af;
    }

    public void _0x012f40dd(int charges)
    {
        this._0x0ee64f46 += charges;
        if (this._0x0ee64f46 > _0x728dc014.ChargesPerIsland)
        {
            this._0x0ee64f46 = _0x728dc014.ChargesPerIsland;
        }
    }

    public int _0xe32a8242
    {
        get
        {
            return this._0x0ee64f46;
        }
    }

    private readonly int[] _0x06aa3a1c = new int[]
    {
        50,
        150,
        400
    };
    /// Claims the island: pays the bonus, resets the meter and sails on. Returns true
    /// when the archipelago has looped back to the first island.
    public bool _0x7d19b24b()
    {
        this._0xc145ce05 += this._0x9a151612();
        this._0x0ee64f46 = 0;
        this._0x680e8d77 = this._0x46009547._0x196c0661(this._0x680e8d77 + 1);
        return this._0x680e8d77 == 0;
    }

    private int _0xc145ce05;
    public int _0x6dd74e06
    {
        get
        {
            return this._0x06aa3a1c.Length;
        }
    }

    public bool _0x4cb3b664()
    {
        return this._0xc145ce05 < this._0x06aa3a1c[0];
    }

    public bool _0x33be774d
    {
        get
        {
            return this._0xacd8f25c._0x7a7a636b;
        }
    }

    public _0x8e73d9ff _0xcef230e1
    {
        get
        {
            return this._0xb2db4cf0;
        }
    }

    public const int DudChargeOnly = 0;
    public const int StartingCoins = 2500;
    public int _0x046b0397
    {
        get
        {
            return this._0x7b8c24ef;
        }
    }

    /// Where inside the wedge the pointer stops: never closer than 2 degrees to an edge,
    /// so the result is never ambiguous on screen.
    private int _0xa5192331(int _0x9338d20f)
    {
        int _0x26990bcc = _0x9338d20f > 6 ? 2 : 1;
        int _0xa6843c19 = _0x9338d20f - (_0x26990bcc * 2);
        if (_0xa6843c19 <= 0)
        {
            return _0x9338d20f / 2;
        }

        return _0x26990bcc + this._0x2c31d7fc._0x472c4a41(_0xa6843c19);
    }

    public int _0x4d67fcb6
    {
        get
        {
            return this._0x57fb9d07;
        }
    }

    private readonly _0xbacdda19 _0xacd8f25c = new _0xbacdda19();
    public void _0x162e7794()
    {
        this._0xc145ce05 += RefillCoins;
    }

    public int _0xc262b495
    {
        get
        {
            return this._0xc145ce05;
        }
    }

    public int _0xc58e11b2
    {
        get
        {
            return this._0x2c31d7fc != null ? this._0x2c31d7fc._0x44928f04 : 0;
        }
    }

    private int _0xbe8b5f28;
    private readonly _0x8e73d9ff _0xb2db4cf0 = new _0x8e73d9ff();
    /// One onboarding exception, stated openly: the FIRST spin of a session is scripted
    /// to land on TREASURE, so a new player meets the bonus round immediately. It applies
    /// to spin #1 only and is excluded from every distribution claim.
    private int _0x1737547f()
    {
        if (!this._0x4c2d90d8)
        {
            for (int _0xb84751be = 0; _0xb84751be < this._0xecafcf4c.Length; _0xb84751be++)
            {
                if (this._0xecafcf4c[_0xb84751be].Kind == _0xf64f5669.Treasure)
                {
                    return _0xb84751be;
                }
            }
        }

        int _0x4d93bbf6 = this._0x2c31d7fc._0x472c4a41(_0x18daa9a8.FullCircle);
        int _0x75d6e978 = 0;
        for (int _0x9a886581 = 0; _0x9a886581 < this._0xecafcf4c.Length; _0x9a886581++)
        {
            _0x75d6e978 += this._0xecafcf4c[_0x9a886581].Angle;
            if (_0x4d93bbf6 < _0x75d6e978)
            {
                return _0x9a886581;
            }
        }

        return this._0xecafcf4c.Length - 1;
    }

    private int _0x680e8d77;
    /// Resolves one spin. The outcome is drawn FIRST and the visual stop angle follows
    /// from it, so what the wheel shows is what the rules decided.
    public _0xb927ebb5 _0x1d878d68(bool _0x3e8b1c4e)
    {
        _0xb927ebb5 _0xadac7bc9 = new _0xb927ebb5();
        int bet = this._0x92246ec2;
        if (_0x3e8b1c4e)
        {
            this._0xc145ce05 -= bet;
        }

        int _0xc8b37e0d = this._0x1737547f();
        _0x0435f2a6 _0x8a7ecdb2 = this._0xecafcf4c[_0xc8b37e0d];
        this._0x7b8c24ef++;
        _0xadac7bc9.SectorIndex = _0xc8b37e0d;
        _0xadac7bc9.Kind = _0x8a7ecdb2.Kind;
        _0xadac7bc9.Label = _0x8a7ecdb2.Label;
        _0xadac7bc9.Bet = bet;
        _0xadac7bc9.Charges = _0x8a7ecdb2.Charges;
        _0xadac7bc9.StopAngle = _0x8a7ecdb2.StartAngle + this._0xa5192331(_0x8a7ecdb2.Angle);
        if (_0x8a7ecdb2.Kind == _0xf64f5669.Multiplier)
        {
            _0xadac7bc9.Win = (int)(bet * _0x8a7ecdb2.Payout);
            this._0xc145ce05 += _0xadac7bc9.Win;
        }
        else if (_0x8a7ecdb2.Kind == _0xf64f5669.Treasure)
        {
            _0xadac7bc9.OpensHunt = true;
            this._0xb2db4cf0._0x2fe63fab(this._0x2c31d7fc);
        }
        else if (_0x8a7ecdb2.Kind == _0xf64f5669.BonusSpin)
        {
            _0xadac7bc9.FreeSpin = true;
        }

        if (_0xadac7bc9.Win > this._0x57fb9d07)
        {
            this._0x57fb9d07 = _0xadac7bc9.Win;
        }

        this._0x012f40dd(_0xadac7bc9.Charges);
        _0xadac7bc9.IslandClaimed = this._0x0ee64f46 >= _0x728dc014.ChargesPerIsland;
        this._0x4c2d90d8 = true;
        return _0xadac7bc9;
    }

    private int _0x57fb9d07;
    public _0x0435f2a6[] _0xd508ee74
    {
        get
        {
            return this._0xecafcf4c;
        }
    }

    public bool _0x036f113d()
    {
        return this._0x0ee64f46 >= _0x728dc014.ChargesPerIsland;
    }

    /// Opens one chest. Returns the coins it paid; the Fortune Key pays charges instead.
    public int _0x420958b8(int _0x3d865876, out int _0xc4169b5c, out int charges)
    {
        _0xc4169b5c = this._0xb2db4cf0._0xb685b377(_0x3d865876);
        charges = 0;
        int win = 0;
        if (_0xc4169b5c == _0x8e73d9ff.ContentCoin)
        {
            win = this._0x92246ec2 * this._0xb2db4cf0._0xc33e3a69(_0x3d865876);
            this._0xc145ce05 += win;
            if (win > this._0x57fb9d07)
            {
                this._0x57fb9d07 = win;
            }
        }
        else if (_0xc4169b5c == _0x8e73d9ff.ContentKey)
        {
            charges = _0x8e73d9ff.KeyCharges;
            this._0x012f40dd(charges);
        }

        return win;
    }

    public bool _0x35900af3()
    {
        return this._0xc145ce05 >= this._0x92246ec2;
    }

    public void _0xa7f1fce1()
    {
        this._0xc145ce05 = StartingCoins;
        this._0x680e8d77 = 0;
        this._0x0ee64f46 = 0;
        this._0xbe8b5f28 = 0;
    }

    public int _0x9a151612()
    {
        return this._0x92246ec2 * _0x728dc014.IslandBonusMultiplier;
    }

    public int _0x92246ec2
    {
        get
        {
            return this._0x06aa3a1c[this._0xbe8b5f28];
        }
    }

    public int _0x6cbf7f72
    {
        get
        {
            return this._0xbe8b5f28;
        }
    }

    private int _0x0ee64f46;
    public void _0x92e29e08(int _0x94748f1c)
    {
        this._0xc145ce05 = _0x94748f1c;
    }

    public _0x728dc014 _0x53e3d196
    {
        get
        {
            return this._0x46009547;
        }
    }

    public int _0x63540d22
    {
        get
        {
            return this._0x680e8d77;
        }
    }

    private readonly _0x728dc014 _0x46009547 = new _0x728dc014();
    public void _0x7b958dd0(int _0x304a4504, int _0x1989f22d, int _0x617daa52, int _0x9b337613)
    {
        this._0x680e8d77 = this._0x46009547._0x196c0661(_0x304a4504);
        this._0xc145ce05 = _0x617daa52;
        this._0x0ee64f46 = _0x9b337613;
        this._0xbe8b5f28 = 0;
        this._0x7b8c24ef = 0;
        this._0x57fb9d07 = 0;
        this._0x4c2d90d8 = false;
        this._0x2c31d7fc = new _0xaecf408d(this._0x680e8d77, _0x1989f22d);
        this._0xecafcf4c = this._0xacd8f25c._0x2782c20e(this._0x2c31d7fc);
    }

    private bool _0x4c2d90d8;
    public void _0x0a0fff4a(int amount)
    {
        this._0xc145ce05 += amount;
    }

    private _0xaecf408d _0x2c31d7fc;
    private _0x0435f2a6[] _0xecafcf4c;
    private int _0x7b8c24ef;
    public int _0x8f8e4c83(int _0xf63a1650)
    {
        return this._0x06aa3a1c[_0xf63a1650];
    }

    public const int RefillCoins = 500;
}