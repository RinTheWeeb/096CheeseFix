using System;
using System.ComponentModel;
using Exiled.API.Interfaces;

namespace OhNeinSixCheeseFix
{
	public class Config : IConfig
	{
		[Description("Whether or not the plugin is enabled.")]
		public bool IsEnabled { get; set; } = true;

		public bool IgnoreTutorial { get; set; } = true;

		public float Distance { get; set; } = 0.5f;

		public float HintDisplayTime { get; set; } = 3f;

		public string HintText { get; set; } = "You enraged 096 by standing beside him. You better run.";

		public float WindupTime { get; set; } = 1f;
	}
}
