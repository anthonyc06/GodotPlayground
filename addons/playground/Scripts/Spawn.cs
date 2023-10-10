using Godot;
using System;

public partial class Spawn : Node
{
	[Export] string keyName;
	[Export] Node2D spawnPosition;
	[Export] PackedScene sceneToSpawn;

	public override void _Process(double delta)
	{
		if(Input.IsActionJustPressed(keyName))
		{
			Node2D spawnedScene = (Node2D) sceneToSpawn.Instantiate();
			spawnedScene.GlobalTransform = spawnPosition.GlobalTransform;
			GetTree().CurrentScene.CallDeferred("add_child", spawnedScene);
		}
	}
}
