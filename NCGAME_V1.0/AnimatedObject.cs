using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCGAME_V1._0
{
   public abstract class AnimatedObject
    {
		protected int _x;
		protected int _y;
		public AnimatedObject()
		{
		}
		public int X
		{
			get { return _x; }
			set { _x = value; }
		}

		public int Y
		{
			get { return _y; }
			set { _y = value; }
		}

	}
}
