using UnityEngine;
using System.Collections;

namespace Game.V1.Extension
{
	public static class ColourExtensions
	{
		public static Color WithAlpha (this Color color, float alpha)
		{
			return new Color (color.r, color.g, color.b, alpha);
		}

	}
}
