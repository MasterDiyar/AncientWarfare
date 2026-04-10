using System.Collections.Generic;
using System.Linq;
using Godot;

namespace Chaos.script.player
{
    public static class ItemFactory
    {

        public static Item Sword() => new Item("Sword", 10, Item.ItemType.Weapon, new List<Vector2>() 
        { Vector2.Zero, Vector2.Down, Vector2.One, Vector2.Right }.Select(i => i + Vector2.Up/2).ToList());
        
        public static Item Axe() => new Item("Sword", 5, Item.ItemType.Weapon, new List<Vector2>() 
            { Vector2.Up, Vector2.Down * 2, Vector2.One * 0.5f }.Select(i => i + Vector2.Up/2).ToList());
    }
}