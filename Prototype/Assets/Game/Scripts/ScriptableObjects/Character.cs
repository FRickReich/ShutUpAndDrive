using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Objects
{
    [CreateAssetMenu(fileName = "Character", menuName = "Game/Character", order = 0)]
	public class Character : ScriptableObject
	{
        public enum Faction
        {
            POLICE,
            MAFIA,
            PLAYER,
            NONE
        }

		public string   characterName = "New Character";
        public Sprite    portrait =      null;
        public Faction  faction =       Faction.NONE;
        public int      health =        100;
        public int      armor =         0;
        public bool     isInvincible =  false;
	}
}
