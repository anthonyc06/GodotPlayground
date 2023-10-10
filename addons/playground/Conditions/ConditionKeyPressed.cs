using Godot;
using System;

public partial class ConditionKeyPressed : Node2D
{
	[Export] string keyName;
	[Export] string actionToCall;
	
	public override void _Process(double delta)
	{
		if(Input.IsActionJustPressed(keyName))
		{
			GetParent().GetNode(actionToCall).Call(actionToCall+"Parent");
		}
	}
}
