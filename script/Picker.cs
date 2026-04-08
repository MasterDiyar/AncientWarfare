using Chaos.script.player;
using Godot;

namespace Chaos.script {
public class Picker : Control {
    private HBoxContainer _spawnNode;
    public override void _Ready()
    {
        _spawnNode = GetNode<HBoxContainer>("HBoxContainer");
        InitBlocks();
    }

    public void InitBlocks(int count = 4)
    {
        var scene = GD.Load<PackedScene>("res://scene/ui/Block.tscn");
    
        for (int i = 0; i < count; i++){
            var block = scene.Instance<Block>();
            block.Randomize();
            block.Initialize();
            _spawnNode.AddChild(block);
        }
    }
}
}
