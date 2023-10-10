#if TOOLS
using Godot;
using System;

[Tool]
public partial class playground : EditorPlugin
{
	public override void _EnterTree()
	{
		RegisterCustomNodes();
		RegisterActions();
		RegisterConditions();
	}

	public override void _ExitTree()
	{
		FreeCustomNodes();
		FreeActions();
		FreeConditions();
	}
	
	public void RegisterCustomNodes()
	{
		// Simple Move
		var simpleMoveScript = GD.Load<Script>("res://addons/playground/Scripts/SimpleMove.cs");
		var simpleMoveTexture = GD.Load<Texture2D>("res://addons/playground/Icons/simpleMove.png");
		AddCustomType("SimpleMove", "Node2D", simpleMoveScript, simpleMoveTexture);
		
		// Follow
		var followScript = GD.Load<Script>("res://addons/playground/Scripts/Follow.cs");
		var followTexture = GD.Load<Texture2D>("res://addons/playground/Icons/follow.png");
		AddCustomType("Follow", "Node2D", followScript, followTexture);
		
		// Auto Move
		var autoMoveScript = GD.Load<Script>("res://addons/playground/Scripts/AutoMove.cs");
		var autoMoveTexture = GD.Load<Texture2D>("res://addons/playground/Icons/autoMove.png");
		AddCustomType("AutoMove", "Node2D", autoMoveScript, autoMoveTexture);
		
		// Auto Rotate
		var autoRotateScript = GD.Load<Script>("res://addons/playground/Scripts/AutoRotate.cs");
		var autoRotateTexture = GD.Load<Texture2D>("res://addons/playground/Icons/autoRotate.png");
		AddCustomType("AutoRotate", "Node2D", autoRotateScript, autoRotateTexture);
		
		// Spawn
		var spawnScript = GD.Load<Script>("res://addons/playground/Scripts/Spawn.cs");
		var spawnTexture = GD.Load<Texture2D>("res://addons/playground/Icons/spawn.png");
		AddCustomType("Spawn", "Node2D", spawnScript, spawnTexture);
		
		// Patrol
		var patrolScript = GD.Load<Script>("res://addons/playground/Scripts/Patrol.cs");
		var patrolTexture = GD.Load<Texture2D>("res://addons/playground/Icons/patrol.png");
		AddCustomType("Patrol", "Node2D", patrolScript, patrolTexture);
		
		// Torque Move
		var torqueScript = GD.Load<Script>("res://addons/playground/Scripts/TorqueMove.cs");
		var torqueTexture = GD.Load<Texture2D>("res://addons/playground/Icons/torque.png");
		AddCustomType("TorqueMove", "Node2D", torqueScript, torqueTexture);
		
		// Spawn repeating
		var spawnerScript = GD.Load<Script>("res://addons/playground/Scripts/SpawnRepeating.cs");
		var spawnerTexture = GD.Load<Texture2D>("res://addons/playground/Icons/spawnRepeating.png");
		AddCustomType("SpawnRepeating", "Node2D", spawnerScript, spawnerTexture);
		
		// Destroy after
		var destroyAfterScript = GD.Load<Script>("res://addons/playground/Scripts/DestroyAfterSeconds.cs");
		var destroyAfterTexture = GD.Load<Texture2D>("res://addons/playground/Icons/destroyAfter.png");
		AddCustomType("DestroyAfterDelay", "Node2D", destroyAfterScript, destroyAfterTexture);
		
		// Shooter
		var shooterScript = GD.Load<Script>("res://addons/playground/Scripts/Shooter.cs");
		var shooterTexture = GD.Load<Texture2D>("res://addons/playground/Icons/shooter.png");
		AddCustomType("Shooter", "Node2D", shooterScript, shooterTexture);
		
		// Ladder
		var climbScript = GD.Load<Script>("res://addons/playground/Scripts/Climbable.cs");
		var climbTexture = GD.Load<Texture2D>("res://addons/playground/Icons/ladder.png");
		AddCustomType("Ladder", "Node2D", climbScript, climbTexture);
		
		// Flip
		var flipScript = GD.Load<Script>("res://addons/playground/Scripts/Flip.cs");
		var flipTexture = GD.Load<Texture2D>("res://addons/playground/Icons/flip.png");
		AddCustomType("FlipDirection", "Node2D", flipScript, flipTexture);
		
		// Trampoline
		var trampolineScript = GD.Load<Script>("res://addons/playground/Scripts/Catapult.cs");
		var trampolineTexture = GD.Load<Texture2D>("res://addons/playground/Icons/catapult.png");
		AddCustomType("Trampoline", "Node2D", trampolineScript, trampolineTexture);
		
		
	}
	
	public void FreeCustomNodes()
	{
		RemoveCustomType("SimpleMove");
		RemoveCustomType("Follow");
		RemoveCustomType("AutoMove");
		RemoveCustomType("AutoRotate");
		RemoveCustomType("Spawn");
		
		RemoveCustomType("Patrol");
		RemoveCustomType("TorqueMove");
		RemoveCustomType("SpawnRepeating");
		RemoveCustomType("DestroyAfterDelay");
		RemoveCustomType("Shooter");
		
		RemoveCustomType("Ladder");
		RemoveCustomType("FlipDirection");
		RemoveCustomType("Trampoline");
	}
	
	public void RegisterActions()
	{
		// Destroy
		var actionDestroyScript = GD.Load<Script>("res://addons/playground/Actions/ActionDestroy.cs");
		var actionDestroyTexture = GD.Load<Texture2D>("res://addons/playground/Icons/destroy.png");
		AddCustomType("ActionDestroy", "Node2D", actionDestroyScript, actionDestroyTexture);
		
		// Instantiate
		var actionInstantiateScript = GD.Load<Script>("res://addons/playground/Actions/ActionInstantiate.cs");
		var actionInstantiateTexture = GD.Load<Texture2D>("res://addons/playground/Icons/spawn.png");
		AddCustomType("ActionInstantiate", "Node2D", actionInstantiateScript, actionInstantiateTexture);
		
	}
	
	public void RegisterConditions()
	{
		// Key Pressed
		var conditionKeyPressedScript = GD.Load<Script>("res://addons/playground/Conditions/ConditionKeyPressed.cs");
		var conditionKeyPressedTexture = GD.Load<Texture2D>("res://addons/playground/Icons/key.png");
		AddCustomType("ConditionKeyPressed", "Node2D", conditionKeyPressedScript, conditionKeyPressedTexture);
		
		// Body entered area
		var conditionBodyEnteredScript = GD.Load<Script>("res://addons/playground/Conditions/ConditionAreaEntered.cs");
		var conditionBodyEnteredTexture = GD.Load<Texture2D>("res://addons/playground/Icons/collision.png");
		AddCustomType("ConditionBodyEntered", "Node2D", conditionBodyEnteredScript, conditionBodyEnteredTexture);
		
	}
		
	public void FreeActions()
	{
		RemoveCustomType("ActionDestroy");
		RemoveCustomType("ActionInstantiate");
	}
	
	public void FreeConditions()
	{
		RemoveCustomType("ConditionKeyPressed");
		RemoveCustomType("ConditionBodyEntered");
	}
	
}
#endif
