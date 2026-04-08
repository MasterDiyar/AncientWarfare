using System.Collections.Generic;
using Godot;

namespace Chaos.script.player {
public static class ImageLoader {

    #region Act
    static readonly Dictionary<Act, string> ActImageDict = new Dictionary<Act, string>()
    {
        [Act.Attack] = "res://assets/mult/Attack.png",
        [Act.Heal] = "res://assets/mult/Heal.png",
        [Act.Move] = "res://assets/mult/Move.png"
    };
    
    public static Texture ActImage(Act act) => GD.Load<Texture>(ActImageDict[act]);
    #endregion

    #region Direction
    private static readonly Dictionary<Direction, string> DirImageDict = new Dictionary<Direction, string>() {
        [Direction.Up] = "res://assets/mult/up.png",
        [Direction.Down] = "res://assets/mult/down.png",
        [Direction.Left] = "res://assets/mult/left.png",
        [Direction.Right] = "res://assets/mult/right.png",
        [Direction.Here] = "res://assets/mult/here.png"
    };
    
    public static Texture DirImage(Direction dir) => GD.Load<Texture>(DirImageDict[dir]);

    #endregion
    
    #region Multiplier

    private static readonly Dictionary<Multiplier, string> MultImageDict = new Dictionary<Multiplier, string>() {
        [Multiplier.Quarter] = "res://assets/mult/Quarter.png",
        [Multiplier.Third] = "res://assets/mult/Third.png",
        [Multiplier.Half] = "res://assets/mult/Half.png",
        [Multiplier.TwoThirds] = "res://assets/mult/TwoThirds.png",
        [Multiplier.ThreeFourths] = "res://assets/mult/ThreeFourth.png",
        [Multiplier.One] = "res://assets/mult/One.png",
        [Multiplier.FiveFourths] = "res://assets/mult/FiveFourth.png",
        [Multiplier.OneAndHalf] = "res://assets/mult/OneAndHalf.png",
        [Multiplier.Two] = "res://assets/mult/Two.png",
        [Multiplier.TwoAndHalf] = "res://assets/mult/TwoAndHalf.png",
        [Multiplier.Three] = "res://assets/mult/Three.png",
        [Multiplier.Ten] = "res://assets/mult/Ten.png"
    };
    
    public static Texture MultImage(Multiplier mult) => GD.Load<Texture>(MultImageDict[mult]);

    #endregion
} }