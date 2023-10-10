using Godot;
using System;

public partial class DestroyAfterSeconds : Node
{
	[Export] float delay;

	public override void _Ready()
	{
		DestroyAfterDelay();
	}
	
	private async void DestroyAfterDelay()
	{
		await ToSignal(GetTree().CreateTimer(delay), "timeout");
		GetParent().QueueFree();
	}

}
