using Godot;
using System;

public partial class ActionInstantiate : Node2D
{
	[Export] Node2D spawnPosition;
	[Export] PackedScene sceneToSpawn;

	public void ActionInstantiateParent()
	{
		Node2D spawnedScene = (Node2D) sceneToSpawn.Instantiate();
		spawnedScene.GlobalTransform = spawnPosition.GlobalTransform;
		GetTree().CurrentScene.CallDeferred("add_child", spawnedScene);
	}
}
