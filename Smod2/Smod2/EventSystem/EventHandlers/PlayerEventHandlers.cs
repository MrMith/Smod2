﻿using Smod2.Events;

namespace Smod2.EventHandlers
{
	public interface IEventHandlerPlayerHurt : IEventHandler
	{

		/// <summary>  
		/// This is called before the player is going to take damage.
		/// In case the attacker can't be passed, attacker will be null (fall damage etc)
		/// This may be broken into two events in the future
		/// </summary> 
		void OnPlayerHurt(PlayerHurtEvent ev);
	}

	public interface IEventHandlerPlayerDie : IEventHandler
	{
		/// <summary>  
		/// This is called before the player is about to die. Be sure to check if player is SCP106 (classID 3) and if so, set spawnRagdoll to false.
		/// In case the killer can't be passed, attacker will be null, so check for that before doing something.
		/// </summary> 
		void OnPlayerDie(PlayerDeathEvent ev);
	}

	public interface IEventHandlerPlayerPickupItem : IEventHandler
	{
		/// <summary>  
		/// This is called when a player picks up an item.
		/// </summary> 
		void OnPlayerPickupItem(PlayerPickupItemEvent ev);
	}

	public interface IEventHandlerPlayerDropItem : IEventHandler
	{
		/// <summary>  
		/// This is called when a player drops up an item.
		/// </summary> 
		void OnPlayerDropItem(PlayerDropItemEvent ev);
	}

	public interface IEventHandlerPlayerJoin : IEventHandler
	{
		/// <summary>  
		/// This is called when a player joins and is initialised.
		/// </summary> 
		void OnPlayerJoin(PlayerJoinEvent ev);
	}

	public interface IEventHandlerNicknameSet : IEventHandler
	{
		/// <summary>  
		/// This is called when a player attempts to set their nickname after joining. This will only be called once per game join.
		/// </summary> 
		void OnNicknameSet(PlayerNicknameSetEvent ev);
	}

	public interface IEventHandlerAssignTeam : IEventHandler
	{
		/// <summary>  
		/// Called when a team is picked for a player. Nothing is assigned to the player, but you can change what team the player will spawn as.
		/// <summary>  
		void OnAssignTeam(PlayerAssignTeamEvent ev);
	}

	public interface IEventHandlerSetRole : IEventHandler
	{
		/// <summary>  
		/// Called after the player is set a class, at any point in the game. 
		/// <summary>  
		void OnSetRole(PlayerSetRoleEvent ev);
	}
}