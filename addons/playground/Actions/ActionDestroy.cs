using Godot;
using System;

public partial class ActionDestroy : Node2D
{
	Node2D parent;
	
	public override void _Ready()
	{
		parent = GetParent() as Node2D;
	}
	
	public void ActionDestroyParent()
	{
		parent.QueueFree();
	}
}
