using Godot;
using System;

public partial class Follow : Node2D
{
	[Export] Node2D target;
	Node2D parent;
	
	public override void _Ready()
	{
		parent = GetParent() as Node2D;
	}

	public override void _PhysicsProcess(double delta)
	{
		if (target != null)
			parent.Position = target.Position;
	}
}
