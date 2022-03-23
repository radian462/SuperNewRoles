﻿using SuperNewRoles.Roles;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperNewRoles.Mode.SuperHostRoles
{
    class ReportDeadBody
    {
        public static bool ReportDeadBodyPatch(PlayerControl __instance,GameData.PlayerInfo target)
        {
            if (!AmongUsClient.Instance.AmHost) return true;
            //会議ボタンでもレポートでも起こる処理

            if (target == null) {
                //会議ボタンのみで起こる処理

                return true;
            };

            //死体レポートのみで起こる処理

            if (__instance.isRole(CustomRPC.RoleId.Minimalist))
            {
                var a = RoleClass.Minimalist.UseReport;
                return a;
            }
            if (target.Object.isRole(CustomRPC.RoleId.Bait) && !RoleClass.Bait.ReportedPlayer.Contains(target.PlayerId)) return false;
            return true;
        }
    }
}
