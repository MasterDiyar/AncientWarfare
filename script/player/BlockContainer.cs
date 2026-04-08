using Godot;
using System;

namespace Chaos.script.player{
public class BlockContainer : Container
{
    public Duration    Dur;
    public Direction   Dir;
    public Multiplier  Mut;
    public Act         Act;

    public TextureRect BaseText, DirText, DurText, MultText, EffectText;

    public override void _Ready()
    {
        BaseText = GetNode<TextureRect>("Base");
        DirText = GetNode<TextureRect>("Direction");
        DurText = GetNode<TextureRect>("Duration");
        MultText = GetNode<TextureRect>("Multiplication");
        EffectText = GetNode<TextureRect>("Effect");
    }

    public void Initialize(Duration duration, Direction dir, Multiplier mut, Act act)
    {
        _Ready();
        GD.Print("Kakoi moment???");
        Dur = duration;
        Dir = dir;
        Mut = mut;
        Act   = act;
        GD.Print("TakoiMoment");

        BaseText.Texture = ImageLoader.ActImage(Act);
        DirText.Texture  = ImageLoader.DirImage(Dir);
        MultText.Texture = ImageLoader.MultImage(Mut);
    }

    public void Shuffle (ulong seed = 0)
    {
        GD.Seed(seed);
        
        Initialize(RandEnum<Duration>(), RandEnum<Direction>(), RandEnum<Multiplier>(), RandEnum<Act>());
    }

    public T RandEnum<T>() where T : Enum
    {
        var values = Enum.GetValues(typeof(T));
        return (T)values.GetValue(GD.Randi() % (uint)values.Length);
    }
}
}