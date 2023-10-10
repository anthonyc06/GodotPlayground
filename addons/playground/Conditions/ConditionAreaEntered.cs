using Godot;
using System;

public partial class ConditionAreaEntered : Area2D
{
	[Export] string actionToCall;
	
	public override void _Process(double delta)
	{
		if (HasOverlappingBodies())
		{
			GetParent().GetNode(actionToCall).Call(actionToCall+"Parent");
		}
	}
}
