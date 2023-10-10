using Godot;
using System;

public partial class Climbable : Area2D
{
	Node2D player;
	Vector2 direction = new Vector2(0f, -1f);
	[Export] float speed;

	public override void _Process(double delta)
	{
		if (HasOverlappingBodies())
		{
			player = GetOverlappingBodies()[0];
		}
		else
		{
			player = null;
		}
		
		if (Input.IsActionPressed("ui_up") && player != null)
		{
			player.Translate(direction * speed);
		}
	}
}
