using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCGAME_V1._0
{
    class Obstacle:AnimatedObject
    {
		private int _hp;

		public Obstacle()
		{
			_hp = 200;
		}
		public Obstacle(int X, int Y)
		{
			_hp = 200;
			_x = X;
			_y = Y;
		}
		public int Hp
		{
			get { return _hp; }
			set { _hp = value; }
		}

	}
}
