using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace SmoothSliders
{
	[HarmonyPatch(typeof(PLInGameUI), "Update")]
	internal class PLInGameUIPatch
	{
		public static void Postfix(PLInGameUI __instance)
		{
			if (__instance != null && PLInputPatch.Initialized)
			{
				if (PLInput.Instance.GetButtonDown(PLInputBase.EInputActionName.INPUT_ACTION_MAX + 1))
				{
					PLUIEditableReactorEditBarPatch.SmoothSlidersEnabled = !PLUIEditableReactorEditBarPatch.SmoothSlidersEnabled;
				}
			}
		}
	}
}
