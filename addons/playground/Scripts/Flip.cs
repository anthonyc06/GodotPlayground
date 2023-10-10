using Godot;
using System;

public partial class Flip : Node
{
	Node2D parent;
	[Export] bool facingLeft = false;
	
	public override void _Ready()
	{
		parent = GetParent() as Node2D;
	}
	
	public override void _Process(double delta)
	{
		if (Input.IsActionJustPressed("ui_left") && !facingLeft)
		{
			facingLeft = true;
			parent.Scale = parent.Scale.Bounce(Vector2.Left);
		}
		
		else if (Input.IsActionJustPressed("ui_right") && facingLeft)
		{
			facingLeft = false;
			parent.Scale = parent.Scale.Bounce(Vector2.Right);
		}
	}
}
