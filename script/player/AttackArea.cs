using Godot;
using System;
using System.Collections.Generic;

public class AttackArea : Area2D
{
    public float LiveTime = 5;
    CollisionPolygon2D cPolygon;
    public override void _Ready()
    {
        cPolygon = GetNode<CollisionPolygon2D>("CollisionPolygon2D");
    }

    public void SetShape(Vector2[] shape) => cPolygon.Polygon = shape;
    
    public void SetShape(List<Vector2> shape) => cPolygon.Polygon = shape.ToArray();

    public override void _Process(float delta)
    {
        if (LiveTime <= 0) QueueFree();
        LiveTime -= delta;
    }
}
