using Godot;

namespace KamehamenamiGame.Entities;

public abstract class MovingEntity: CharacterBody2D
{
    [Export()]
    public float MoveSpeed { get; set; }
}