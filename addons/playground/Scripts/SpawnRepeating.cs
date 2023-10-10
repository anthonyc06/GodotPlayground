using Godot;
using System;

public partial class SpawnRepeating : Node2D
{
	[Export] float delay;
	[Export] Node2D spawnPosition;
	[Export] PackedScene sceneToSpawn;

	public override void _Ready()
	{
		SpawnAndWait();
	}
	
	private async void SpawnAndWait()
	{
		Node2D spawnedScene = (Node2D) sceneToSpawn.Instantiate();
		spawnedScene.GlobalTransform = spawnPosition.GlobalTransform;
		GetTree().CurrentScene.CallDeferred("add_child", spawnedScene);
			
		await ToSignal(GetTree().CreateTimer(delay), "timeout");
		SpawnAndWait();
	}
}
