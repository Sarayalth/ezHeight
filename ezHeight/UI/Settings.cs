using BeatSaberMarkupLanguage.Attributes;
using System.Linq;
using UnityEngine;
namespace ezHeight.UI
{
	class Settings : PersistentSingleton<Settings>
	{
		public PlayerDataModel _playerDataModel;

		public void Awake()
		{
			_playerDataModel = Resources.FindObjectsOfTypeAll<PlayerDataModel>().FirstOrDefault();
		}

		[UIValue("player-height")]
		public float playerHeight {
			get => _playerDataModel.playerData.playerSpecificSettings.playerHeight;
			set {
				_playerDataModel.playerData.playerSpecificSettings.playerHeight = value;
			}
		}
	}
}
