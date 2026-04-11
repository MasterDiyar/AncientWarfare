using Godot;
using System;

public class Game : Node2D
{
    public override void _Ready()
    {
        GameManager.PausableNode = GetNode<Node2D>("Pausable");
        GameManager.UI = GetNode<CanvasLayer>("UI");
        
    }
    
}
