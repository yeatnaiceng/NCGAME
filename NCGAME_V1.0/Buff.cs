using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCGAME_V1._0
{
    class Buff:AnimatedObject
    {
		private BuffN _buffName;
		private int _effectRound;

		public Buff()
		{
		}
		public BuffN BuffName
		{
			get { return _buffName; }
			set { _buffName = value; }
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
