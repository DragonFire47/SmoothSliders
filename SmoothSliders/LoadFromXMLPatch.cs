using System;
using System.Collections.Generic;
using HarmonyLib;

namespace SmoothSliders
{
    [HarmonyPatch(typeof(PLInput), "LoadFromXmlDoc")]
    internal class LoadFromXMLPatch
    {
		public static void Postfix(PLInput __instance, string xmlFileName)
		{
			List<PLInputAction> list = __instance.FindActionsByID("toggle_smoothsliders");
			int num = 0;
			PLInputCategory plinputCategory = null;
			foreach (PLInputCategory plinputCategory2 in __instance.AllInputCategories)
			{
				if (plinputCategory2 != null && plinputCategory2.m_Name == "Basics")
				{
					plinputCategory = plinputCategory2;
					break;
				}
			}
			using (List<PLInputAction>.Enumerator enumerator2 = list.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					if (enumerator2.Current.m_Category == plinputCategory)
					{
						num++;
					}
				}
			}
			if (num == 0 && plinputCategory != null)
			{
				PLInputAction plinputAction = new PLInputAction("Toggle Smooth Sliders", "toggle_smoothsliders", plinputCategory);
				plinputAction.AddKey(new PLInputKey
				{
					Type = "standard",
					ID = "k",
					ID_Upper = "K"
				});
				__instance.AllInputActions.Add(plinputAction);
				plinputAction.m_Category = plinputCategory;
				__instance.SaveToXmlFile(xmlFileName, false);
			}
		}
	}
}
