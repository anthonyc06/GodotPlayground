using Godot;
using System;

public partial class AutoMove : Node2D
{
	[Export] Vector2 direction = new Vector2(1f, 0f);
	Node2D parent;
	
	public override void _Ready()
	{
		parent = GetParent() as Node2D;
	}
	
	public override void _PhysicsProcess(double delta)
	{
		parent.Translate(direction);
	}
}
