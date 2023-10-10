using Godot;
using System;

public partial class Patrol : Node2D
{
	[Export] float speed = 120f;
	[Export] Node2D[] points;
	private int index = 0;
	
	CharacterBody2D parent;
	
	public override void _Ready()
	{
		parent = GetParent() as CharacterBody2D;
	}
	
	public override void _PhysicsProcess(double delta)
	{
		var dir = (points[index].Position - parent.Position).Normalized();

		if (parent.Position.DistanceTo(points[index].Position) >= 0.75f)
		{
			parent.Velocity = dir * speed;
			parent.MoveAndSlide(); 
		} 
		else
		{
			index++;
			if (index > points.Length - 1)
			{
				index = 0;
			}
		}
	}
}
