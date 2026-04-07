using System;
using Godot;

namespace Chaos.script.player {
public class Block : Button
{
	[Export] public Multiplier Multiplier;
	[Export] public Act Act;
	[Export] public Direction Direction;
	[Export] public Duration Duration;



	public override void _Ready()
	{
	
	}

	public void Operate(){
	
	
	}

	

	public Block RandomBlock() {
		Multiplier = (Multiplier)(GD.Randi() % MultiplierCount);
		Act = (Act)(GD.Randi() % ActCount);
		Direction = (Direction)(GD.Randi() % DirectionCount);
    
		return this;
	}
	private static readonly int MultiplierCount = Enum.GetNames(typeof(Multiplier)).Length;
    private static readonly int ActCount = Enum.GetNames(typeof(Act)).Length;
    private static readonly int DirectionCount = Enum.GetNames(typeof(Direction)).Length;
}

}
