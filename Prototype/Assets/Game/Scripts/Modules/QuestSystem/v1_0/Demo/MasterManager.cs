using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Game.Base;

[CreateAssetMenu(menuName = "Game/Manager/MasterManager")]
public class MasterManager : SingletonScriptableObject<MasterManager>
{
    [SerializeField]
    private SpeedManager _speedManager;

	public SpeedManager SpeedManager { get => _speedManager; }
}
