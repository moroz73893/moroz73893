/// One painted wedge of the prize wheel. Angles are degrees of the 360 circle, so a
/// sector's probability is exactly Angle / 360 and nothing has to be normalised later.
public sealed class _0x0435f2a6
{
    public string Label;
    public int StartAngle;
    public _0xf64f5669 Kind;
    public bool IsGoldBand;
    public int Charges;
    public int TintIndex;
    public int GemIndex;
    public int Angle;
    public _0x0435f2a6(_0xf64f5669 _0x88f49e49, int _0x30fab404, float _0xdbedb016, string _0x496ce953, int _0xe29292d9, int _0x0b95e9a5, int _0xe91ef642, bool _0x02990154)
    {
        this.Kind = _0x88f49e49;
        this.Angle = _0x30fab404;
        this.Payout = _0xdbedb016;
        this.Label = _0x496ce953;
        this.GemIndex = _0xe29292d9;
        this.Charges = _0x0b95e9a5;
        this.TintIndex = _0xe91ef642;
        this.IsGoldBand = _0x02990154;
        this.StartAngle = 0;
    }

    public _0x0435f2a6 _0x45724856()
    {
        return new _0x0435f2a6(this.Kind, this.Angle, this.Payout, this.Label, this.GemIndex, this.Charges, this.TintIndex, this.IsGoldBand);
    }

    public float Payout;
}