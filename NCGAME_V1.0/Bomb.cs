using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCGAME_V1._0
{
    class Bomb:AnimatedObject
    {
		private int _damage;
		Random rnd = new Random();
		public Bomb()
		{
			_damage = 200;
		}
		public int Damage
		{
			get { return _damage; }
			set { _damage = value; }
		}
		public void Explode(List<AnimatedObject> AnmObj)
		{
			int[] X_Explode = new int[9];
			int[] Y_Explode = new int[9];
			int index = 0;
			int damage;

			for (int a = 0; a < 3; a++)
			{
				for (int b = 0; b < 3; b++)
				{
					X_Explode[index] = (X - 1) + a;
					Y_Explode[index] = (Y - 1) + b;
					index += 1;
				}
			}

			for (int a = 0; a < 9; a++)
			{
				foreach (AnimatedObject b in AnmObj)
				{
					if (b is Player)
					{
						if (b.X == X_Explode[a] && b.Y == Y_Explode[a])
						{
							Player c = b as Player;
							damage = rnd.Next(_damage - 20, _damage + 20) - rnd.Next(c.CharacterChosen.PhysicalDefenseMin, c.CharacterChosen.PhysicalDefenseMax);
							if (damage > 0)
								c.Hp -= damage;
						}
					}
				}
			}

		}
	}
}
