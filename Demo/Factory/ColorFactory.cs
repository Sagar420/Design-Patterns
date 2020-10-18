using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Factory
{
	class ColorFactory
	{
		public Color GetColor(string colorType)
		{
			if (colorType.Equals("Red"))
			{
				return new Red();
			}
			else if (colorType.Equals("Yellow"))
			{
				return new Yellow();
			}
			return new Red();
		}
	}
}
