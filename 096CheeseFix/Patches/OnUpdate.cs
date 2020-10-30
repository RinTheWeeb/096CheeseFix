using Exiled.API.Features;
using Exiled.Events;
using HarmonyLib;
using Hints;
using Mirror;
using UnityEngine;

namespace OhNeinSixCheeseFix.Patches
{
    [HarmonyPatch(typeof(PlayableScps.Scp096), nameof(PlayableScps.Scp096.OnUpdate))]
    public class OnUpdate
    {
        [HarmonyPriority(Priority.First)]
        public static void Postfix(PlayableScps.Scp096 __instance)
        {
            if (!NetworkServer.active && __instance.Hub.gameObject != null)
                return;

            if (!__instance.CanEnrage)
                return;

            foreach (Player player in Player.List)
            {
                if (Plugin.Singleton.Config.IgnoreTutorial && player.Role == RoleType.Tutorial)
                    continue;

                if (__instance._targets.Contains(player.ReferenceHub))
                    continue;

                if (player.Role == RoleType.Spectator || player.Team == Team.SCP)
                    continue;

                var distance = Vector3.Distance(player.Position, __instance.Hub.playerMovementSync.GetRealPosition());
                if (distance <= Plugin.Singleton.Config.Distance)
                {
                    if (!Physics.Linecast(player.Position, __instance.Hub.playerMovementSync.GetRealPosition(), LayerMask.GetMask("Default", "Door", "Glass")))
                        continue;

                    __instance.AddTarget(player.GameObject);
                    __instance.PreWindup(Plugin.Singleton.Config.WindupTime);
                    player.ReferenceHub.hints.Show(new TextHint(Plugin.Singleton.Config.HintText, new HintParameter[] { new StringHintParameter("") }, HintEffectPresets.FadeInAndOut(1f), Plugin.Singleton.Config.HintDisplayTime));
                }
            }
        }
    }
}