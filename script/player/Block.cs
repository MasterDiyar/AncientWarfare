using System;
using Godot;

namespace Chaos.script.player {
public class Block : Button
{
	[Export] public Multiplier Multiplier;
	[Export] public Act Act;
	[Export] public Direction Direction;
	[Export] public Duration Duration;
	

	public void Initialize(bool random = true)
	{
		if (random)
			Randomize();
		
		var bc = GD.Load<PackedScene>("res://scene/ui/BlockContainer.tscn").Instance<BlockContainer>();
		AddChild(bc);
		bc.Initialize(Duration, Direction, Multiplier, Act);
		
	}

	

	public void Randomize() {
		Multiplier = (Multiplier)(GD.Randi() % MultiplierCount);
		Act = (Act)(GD.Randi() % ActCount);
		Direction = (Direction)(GD.Randi() % DirectionCount);
		Duration = (Duration)(GD.Randi() % DurationCount);
    
	}
	private static readonly int MultiplierCount = Enum.GetNames(typeof(Multiplier)).Length;
    private static readonly int ActCount = Enum.GetNames(typeof(Act)).Length;
    private static readonly int DirectionCount = Enum.GetNames(typeof(Direction)).Length;
    private static readonly int DurationCount = Enum.GetNames(typeof(Duration)).Length;
}

}
