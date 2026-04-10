using System.Collections.Generic;
using Godot;
namespace Chaos.script.player
{
    public class Item
    {
        public enum ItemType
        {
            Weapon,
            Armor,
            Heal
        }
        
        public string Name;
        public float Damage;
        public List<Vector2> AttackArea;
        
        public ItemType Type;
        
        public Item(string name, float damage, ItemType type, List<Vector2> attackArea)
        {
            Name = name;
            Damage = damage;
            Type = type;
            AttackArea = attackArea;
        }
        
        public void AddDamage(float multiplier, Unit who)
        {
            who.hp -= Damage * multiplier;
        }
    }
}