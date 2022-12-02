using HarmonyLib;
using System;
using UnityEngine;

namespace SmoothSliders
{
    [HarmonyPatch(typeof(PLInput), "Init")]
    internal class PLInputPatch
    {
		public static bool Initialized = false;

		public static void Postfix(PLInput __instance, ref string[] ___EInputActionNameToString)
		{
			string[] array = new string[133];
			Array.Copy(___EInputActionNameToString, array, __instance.EInputActionNameToString.Length);
			array[132] = "toggle_smoothsliders";
			___EInputActionNameToString = array;
			PLInputPatch.Initialized = true;
		}
	}
}
