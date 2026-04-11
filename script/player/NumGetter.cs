using System.Collections.Generic;
using Godot;

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

        public static readonly Dictionary<Direction, float> Rotation = new Dictionary<Direction, float>()
        {
            [Direction.Up] = Mathf.Pi / 2,
            [Direction.Down] = -Mathf.Pi / 2,
            [Direction.Left] = Mathf.Pi,
            [Direction.Right] = 0,
            [Direction.Here] = 0
        };
        
        public static readonly Dictionary<Direction, Vector2> Position = new Dictionary<Direction, Vector2>()
        {
            [Direction.Up] = Vector2.Up,
            [Direction.Down] = Vector2.Down,
            [Direction.Left] = Vector2.Left,
            [Direction.Right] = Vector2.Right,
            [Direction.Here] = Vector2.Zero
        };
    }
}