using Godot;
using System;
using System.Linq;

namespace Chaos.script.player{
public class Unit : Node2D
{

	[Export] public float MaxHp = 100;
	[Export] public float MaxDamage = 5;

	private Timer timer;
	public override void _Ready()
	{
		timer = GetNode<Timer>("Timer");
		timer.Connect("timeout", this, nameof(ActBlock));
	}

	void ActBlock()
	{
		var block = blocks[currentBlock];

		switch (block.Act)
		{
			case Act.Heal:
				break;
		}
		
		
		currentBlock++;
	}

	int currentBlock = 0;
	Block[] blocks;

	void ParseBlocks()
	{
		foreach (Node childs in GetChildren())
			if (childs is Block bc) blocks = blocks.Append(bc).ToArray();
		
	}
	
	
}
}
