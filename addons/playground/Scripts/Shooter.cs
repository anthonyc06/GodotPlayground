using Godot;
using System;

public partial class Shooter : Node2D
{
	[Export] string keyName;
	[Export] Node2D spawnPosition;
	[Export] PackedScene bulletToSpawn;
	[Export] float shotPower;
	
	public override void _Process(double delta)
	{
		if(Input.IsActionJustPressed(keyName))
		{
			RigidBody2D spawnedScene = (RigidBody2D) bulletToSpawn.Instantiate();
			spawnedScene.GlobalTransform = spawnPosition.GlobalTransform;
			GetTree().CurrentScene.CallDeferred("add_child", spawnedScene);
			
			spawnedScene.ApplyCentralForce(Vector2.Right * shotPower);
			
		}
	}
	
}
