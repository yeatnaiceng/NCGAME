using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCGAME_V1._0
{
    class Debuff:AnimatedObject
    {
		private DebuffN _debuffName;
		private int _effectRound;

		public Debuff()
		{
		}

		public DebuffN DebuffName
		{
			get { return _debuffName; }
			set { _debuffName = value; }
		}

		public int EffectRound
		{
			get { return _effectRound; }
			set { _effectRound = value; }
		}

		public void Effect()
		{

		}
	}
}
