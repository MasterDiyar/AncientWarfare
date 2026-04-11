using Godot;
using System;

public class GameManager : Node2D
{
    public override void _Ready()
    {
        Instance = this;
    }

    public static GameManager Instance {get; private set;}
    
    public static Node2D PausableNode {get; set;}
    public static CanvasLayer UI { get; set; }
}
