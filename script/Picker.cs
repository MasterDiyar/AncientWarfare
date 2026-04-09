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
            
            var binds = new Godot.Collections.Array { block };
            block.Connect("pressed", this, nameof(onPress), binds);
            _spawnNode.AddChild(block);
        }
    }

    void onPress(Block block)
    {
        GD.Print($"Нажат блок: {block.Name}, действие: {block.Act}");
    }
}
}
