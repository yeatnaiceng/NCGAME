using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCGAME_V1._0
{
    class Potion:AnimatedObject
    {
		private PotionN _potionName;
		public Potion()
		{

		}
		public PotionN PotionName
		{
			get { return _potionName; }
			set { _potionName = value; }
		}

		public void Heal()
		{

		}
	}
}
