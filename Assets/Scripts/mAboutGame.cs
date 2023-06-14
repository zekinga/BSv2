using System;
using UnityEngine;

public class mAboutGame : MonoBehaviour
{
	public void YouTube()
	{
		Application.OpenURL("https://www.youtube.com/RexetStudio");
	}

	public void Vkontakte()
	{
		Application.OpenURL("https://vk.com/blockstrike");
	}

	public void Facebook()
	{
		Application.OpenURL("https://www.facebook.com/Block-Strike-1493507804286160/");
	}

	public void Twitter()
	{
		Application.OpenURL("https://twitter.com/RexetStudio");
	}

	public void Share()
	{
		AndroidNativeFunctions.ShareText(Localization.Get("ShareText", true) + "https://play.google.com/store/apps/details?id=com.rexetstudio.blockstrike", "Block Strike", Localization.Get("Share", true));
	}

	public void PrivacyPolicy()
	{
		Application.OpenURL("http://rexetstudio.com/en/privacypolicy");
	}
}
