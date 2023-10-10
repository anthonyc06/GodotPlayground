using Godot;
using System;

public partial class SimpleMove : Node2D
{
	[Export] public float Speed = 500.0f;
	[Export] public float JumpVelocity = -600.0f;
	CharacterBody2D character;

	public float gravity;

	public override void _Ready()
	{
		gravity = ProjectSettings.GetSetting("physics/2d/default_gravity").AsSingle();
		character = GetParent() as CharacterBody2D;
	}
		
	public override void _PhysicsProcess(double delta)
	{
		Vector2 velocity = character.Velocity;

		if (!character.IsOnFloor())
			velocity.Y += gravity * (float)delta;
		
		if (Input.IsActionJustPressed("ui_accept") && character.IsOnFloor())
			velocity.Y = JumpVelocity;
			
		Vector2 direction = Input.GetVector("ui_left", "ui_right", "ui_up", "ui_down");
		if (direction != Vector2.Zero)
		{
			velocity.X = direction.X * Speed;
		}
		else
		{
			velocity.X = Mathf.MoveToward(character.Velocity.X, 0, Speed);
		}

		character.Velocity = velocity;
		character.MoveAndSlide();
	}
}
