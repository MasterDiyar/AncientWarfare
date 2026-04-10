using System.Collections.Generic;

namespace Chaos.script.player
{
    public static class NumGetter
    {
        private static readonly Dictionary<Multiplier, float> multDict = new Dictionary<Multiplier, float>()
        {
            [Multiplier.Zero] = 0,
            [Multiplier.Quarter] = 0.25f,
            [Multiplier.Third] = 0.33f,
            [Multiplier.Half] = 0.5f,
            [Multiplier.TwoThirds] = 0.66f,
            [Multiplier.ThreeFourths] = 0.75f,
            [Multiplier.One] = 1,
            [Multiplier.FiveFourths] = 1.2f,
            [Multiplier.OneAndHalf] = 1.5f,
            [Multiplier.Two] = 2,
            [Multiplier.TwoAndHalf] = 2.5f,
            [Multiplier.Three] = 3,
            [Multiplier.Ten] = 10
        };
        
        public static float GetNumFromMultiplier(Multiplier multiplier) => multDict[multiplier];
    }
}