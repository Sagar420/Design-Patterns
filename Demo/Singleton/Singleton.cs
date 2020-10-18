using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
	sealed class Singleton
	{
		public static Singleton _instace = null;
		private Singleton() { }

		public static Singleton GetInstance()
		{
			if (_instace == null)
			{
				_instace = new Singleton();
			}
			return _instace;
		}
	}
}
