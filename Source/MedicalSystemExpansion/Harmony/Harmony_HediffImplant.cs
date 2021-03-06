﻿using HarmonyLib;
using Verse;

namespace OrenoMSE.Harmony2
{
    public class Harmony_HediffImplant
    {
        [HarmonyPatch(typeof(Hediff_Implant))]
        [HarmonyPatch("PostAdd")]
        internal class HediffImplant_PostAdd
        {
            [HarmonyPostfix]
            [HarmonyPriority(Priority.Last)]
            private static void AdditionalHediff(Hediff_Implant __instance)
            {
                MSE_VanillaExtender.HediffApplyHediffs(__instance, __instance.pawn, __instance.Part);
            }
        }
    }
}
