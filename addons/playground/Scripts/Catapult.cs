using Godot;
using System;

public partial class Catapult : Area2D
{
	[Export] CharacterBody2D player;
	[Export] float catapultForce = 10;
	
	public override void _Process(double delta)
	{
		if (HasOverlappingBodies())
		{
			player.Velocity = new Vector2(player.Velocity.X, catapultForce);
		}
		
	}
}
