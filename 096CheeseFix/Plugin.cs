using System;
using System.Reflection;
using Exiled.API.Features;
using Exiled.Events;
using HarmonyLib;

namespace OhNeinSixCheeseFix
{
	public class Plugin : Plugin<Config>
	{
		public override string Author { get; } = "Rin";

		public override string Name { get; } = "096CheeseFix";

		public override string Prefix { get; } = "096CheeseFix";

		public override Version Version { get; } = new Version(1, 0, 0);

		public static Plugin Singleton;
		public Harmony Harmony;

		public override void OnEnabled()
		{
			Plugin.Singleton = this;

			try
			{
				Harmony = new Harmony(string.Format("com.rin.096cheesefix-{0}", DateTime.Now.Ticks));
				Harmony.PatchAll();
			}
			catch (Exception arg2)
			{
				Log.Error(string.Format("{0}", arg2));
			}
			base.OnEnabled();
		}

		public override void OnDisabled()
		{
			Harmony.UnpatchAll(null);
			Harmony = null;
			base.OnDisabled();
		}
	}
}
