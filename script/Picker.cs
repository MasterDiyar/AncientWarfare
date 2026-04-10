using Chaos.script.player;
using Godot;

namespace Chaos.script {
public class Picker : Control {
    private HBoxContainer _spawnNode;
    private VBoxContainer _placeNode;
    private Button playButton;
    public override void _Ready()
    {
        _spawnNode = GetNode<HBoxContainer>("HBoxContainer");
        _placeNode = GetNode<VBoxContainer>("VBoxContainer");
        playButton = GetNode<Button>("Button");
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
        _spawnNode.RemoveChild(block);
        _placeNode.AddChild(block);
        Reload();
    }

    void Reload(int count = 4)
    {
        foreach (Node blocky in _spawnNode.GetChildren())
                    _spawnNode.RemoveChild(blocky);
        InitBlocks(count);
    }
}
}
