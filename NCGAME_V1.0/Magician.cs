using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NCGAME_V1._0
{
   public class Magician:Character
    {
		Random rnd = new Random();
		public Magician()
		{
			_characterName = "魔法使い";
			_hpState = 700;
			_mpState = 300;
			_mobility = 2;
			_nameSkill1 = "火遁・炎弾";
			_nameSkill2 = "瞬間移動";
			_nameSkill3 = "エクスぷローション";
			_physicalAttackMax = 20;
			_physicalAttackMin = 10;
			_physicalDefenseMax = 10;
			_physicalDefenseMin = 0;
			_magicalAttackMax = 200;
			_magicalAttackMin = 100;
			_magicalDefenseMax = 30;
			_magicalDefenseMin = 20;
		}
		public override void Skill1(List<AnimatedObject> AnmObj, Player player, string Direction)
		{
			int damage;
			int distance = 5;
			int[] X = new int[distance];
			int[] Y = new int[distance];
			if (player.Mp < 40)
				return;
			player.Mp -= 40;
			//Set Attack Range
			if (Direction == "Up")
			{
				for (int a = 0; a < distance; a++)
				{
					X[a] = player.X;
					Y[a] = player.Y - (a + 1);
				}
			}
			else if (Direction == "Down")
			{
				for (int a = 0; a < distance; a++)
				{
					X[a] = player.X;
					Y[a] = player.Y + (a + 1);
				}
			}
			else if (Direction == "Right")
			{
				for (int a = 0; a < distance; a++)
				{
					X[a] = player.X + (a + 1);
					Y[a] = player.Y;
				}
			}
			else
			{
				for (int a = 0; a < distance; a++)
				{
					X[a] = player.X - (a + 1);
					Y[a] = player.Y;
				}
			}
			//Skill activated
			for (int a = 0; a < distance; a++)
			{
				foreach (AnimatedObject b in AnmObj)
				{
					if (b.X == X[a] && b.Y == Y[a])
					{
						if (b is Player)
						{
							Player c = b as Player;
							damage = rnd.Next(_magicalAttackMin, _magicalAttackMax) * 2 - rnd.Next(c.CharacterChosen.MagicalDefenseMin, c.CharacterChosen.MagicalDefenseMax);
							if (damage > 0)
								c.Hp -= damage;
						}
						else if (b is Obstacle)
						{
							Obstacle c = b as Obstacle;
							damage = rnd.Next(_magicalAttackMin, _magicalAttackMax) * 2;
							if (damage > 0)
								c.Hp -= damage;
						}
						else if (b is Bomb)
						{
							Bomb c = b as Bomb;
							c.Explode(AnmObj);
						}
					}

				}
			}
		}
		public override void Skill2(List<AnimatedObject> AnmObj, Player player, string Direction)
		{
			int X_Dest, Y_Dest;
			if (player.Mp < 50)
				return;
			player.Mp -= 50;
			
			
		}
		public override void Skill3(List<AnimatedObject> AnmObj, Player player, string Direction)
		{
			int[] x = new int[25];
			int[] y = new int[25];
			int index = 0;

			if (player.Mp < 300)
				return;
			player.Mp -= 300;

			for (int a = 0; a < 5; a++)
			{
				for (int b = 0; b < 5; b++)
				{
					if (Direction == "Up")
					{
						x[index] = (player.X - 2) + a;
						y[index] = (player.Y + 1) + b;
					}
					else if (Direction == "Down")
					{
						x[index] = (player.X - 2) + a;
						y[index] = (player.Y - 1) - b;
					}
					else if (Direction == "Left")
					{
						x[index] = (player.X - 1) - a;
						y[index] = (player.Y + 2) - b;
					}
					else
					{
						x[index] = (player.X + 1) + a;
						y[index] = (player.Y + 2) - b;
					}
					index++;
				}
			}

			for (int a = 0; a < 25; a++)
			{
				foreach (AnimatedObject b in AnmObj)
				{
					if (b.X == x[a] && b.Y == y[a])
					{
						if (b is Player)
						{
							Player c = b as Player;
							c.Hp -= 1000;
						}
						else if (b is Obstacle)
						{
							Obstacle c = b as Obstacle;
							c.Hp -= 1000;
						}
						else if (b is Bomb)
						{
							Bomb c = b as Bomb;
							c.Explode(AnmObj);
						}
					}
				}
			}



		}
	}
}
