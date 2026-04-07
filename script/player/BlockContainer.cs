using Godot;
using System;

namespace Chaos.script.player{
public class BlockContainer : Container
{
    public Duration    Dur;
    public Direction   Dir;
    public Multiplier  Mut;
    public Act         Act;

    [Export] public TextureRect BaseText, DirText, DurText, MultText, EffectText;

    public void Initialize(Duration duration, Direction dir, Multiplier mut, Act act)
    {
        Dur = duration;
        Dir = dir;
        Mut = mut;
        Act   = act;

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