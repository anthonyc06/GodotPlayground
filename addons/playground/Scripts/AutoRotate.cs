using Godot;
using System;

public partial class AutoRotate : Node2D
{
	[Export] float rotationSpeed = 5;
	Node2D parent;
	
	public override void _Ready()
	{
		parent = GetParent() as Node2D;
	}
	
	public override void _PhysicsProcess(double delta)
	{
		parent.Rotate(rotationSpeed * (float)delta);
	}
}
