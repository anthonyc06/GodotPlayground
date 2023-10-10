using Godot;
using System;

public partial class TorqueMove : Node2D
{
	[Export] float force = 2;
	RigidBody2D parent;
	
	public override void _Ready()
	{
		parent = GetParent() as RigidBody2D;
	}
	
	public override void _Process(double delta)
	{
		if (Input.IsActionPressed("ui_right"))
			parent.ApplyCentralImpulse(Vector2.Right * force);
		if (Input.IsActionPressed("ui_left"))
			parent.ApplyCentralImpulse(Vector2.Left * force);
	}

}
