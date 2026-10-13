/// The six-chest Treasure Hunt board. The multiset is fixed - 3 coin chests worth x1,
/// x2 and x3 of the bet, 1 Fortune Key and 2 empties - so every shuffled board is valid
/// by construction and needs no solvability retry. Expected value of one pick is
/// (1 + 2 + 3) / 6 = 1.00 bet, and the round grants two picks.
public sealed class _0x8e73d9ff
{
    public void _0x2fe63fab(_0xaecf408d _0xad6aa0ca)
    {
        int[] _0x52762579 = new int[]
        {
            ContentCoin,
            ContentCoin,
            ContentCoin,
            ContentKey,
            ContentEmpty,
            ContentEmpty
        };
        int[] _0x7fbc48ce = new int[]
        {
            1,
            2,
            3,
            0,
            0,
            0
        };
        // Shuffle the PAIRS, so a chest keeps the multiplier that belongs to it.
        int[] _0x176ce6dc = new int[]
        {
            0,
            1,
            2,
            3,
            4,
            5
        };
        _0xad6aa0ca._0x73567695(_0x176ce6dc);
        for (int _0xa8a8c8d2 = 0; _0xa8a8c8d2 < ChestCount; _0xa8a8c8d2++)
        {
            this._0x7a25fffb[_0xa8a8c8d2] = _0x52762579[_0x176ce6dc[_0xa8a8c8d2]];
            this._0x7327a70d[_0xa8a8c8d2] = _0x7fbc48ce[_0x176ce6dc[_0xa8a8c8d2]];
        }
    }

    public int _0xb685b377(int _0x1e9dd81b)
    {
        return this._0x7a25fffb[_0x1e9dd81b];
    }

    public int _0xc33e3a69(int _0xe5534978)
    {
        return this._0x7327a70d[_0xe5534978];
    }

    public const int KeyCharges = 3;
    private readonly int[] _0x7a25fffb = new int[ChestCount];
    public const int ContentCoin = 1;
    /// A stable signature of the board, used by the harness to count distinct arrangements.
    public string _0xa3b7a0b7()
    {
        System.Text.StringBuilder _0x994a6a7c = new System.Text.StringBuilder();
        for (int _0x1863da8a = 0; _0x1863da8a < ChestCount; _0x1863da8a++)
        {
            _0x994a6a7c.Append(this._0x7a25fffb[_0x1863da8a]);
            _0x994a6a7c.Append(this._0x7327a70d[_0x1863da8a]);
        }

        return _0x994a6a7c.ToString();
    }

    public const int ContentEmpty = 0;
    public const int ContentKey = 2;
    public const int ChestCount = 6;
    public const int PicksPerRound = 2;
    private readonly int[] _0x7327a70d = new int[ChestCount];
}