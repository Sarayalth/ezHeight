using BeatSaberMarkupLanguage.Settings;
using BS_Utils.Utilities;
using IPA;
using IPALogger = IPA.Logging.Logger;
namespace ezHeight
{
	[Plugin(RuntimeOptions.SingleStartInit)]
	public class Plugin
	{
		internal static Plugin instance { get; private set; }
		internal static string Name => "ezHeight";
		internal static IPALogger log { get; set; }
		[Init]
		public void Init(IPALogger logger)
		{
			instance = this;
			log = logger;
		}
		[OnStart]
		public void OnApplicationStart()
		{
			BSEvents.menuSceneLoadedFresh += BSEvents_menuSceneLoadedFresh;
		}

		private void BSEvents_menuSceneLoadedFresh()
		{
			BSMLSettings.instance.AddSettingsMenu("ezHeight", "ezHeight.UI.Settings.bsml", UI.Settings.instance);
		}

		[OnExit]
		public void OnApplicationQuit(){}
	}
}
