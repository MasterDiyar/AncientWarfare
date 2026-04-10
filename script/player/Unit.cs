using Godot;
using System;
using System.Linq;

namespace Chaos.script.player{
public class Unit : Node2D
{

	[Export] public float MaxHp = 100;
	[Export] public float MaxDamage = 5;

	private Timer timer;
	
	public float hp = 0;

	private Item heal, weapon, armor;
	public override void _Ready()
	{
		heal = ItemFactory.HealWand();
		weapon = ItemFactory.Sword();
		hp = MaxHp;
		timer = GetNode<Timer>("Timer");
		timer.Connect("timeout", this, nameof(ActBlock));
	}

	void ActBlock(Block block)
	{

		switch (block.Act)
		{
			case Act.Heal:
				heal.AddDamage(NumGetter.GetNumFromMultiplier(block.Multiplier), this);
				break;
			case Act.Attack:
				
				break;
		}
		
		
	}
	
}
}
