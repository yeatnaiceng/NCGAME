using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCGAME_V1._0
{
    public class Warrior:Character
    {
		Random rnd = new Random();
		public Warrior()
		{
			_characterName = "戦士";
			_hpState = 1000;
			_mpState = 100;
			_mobility = 3;
			_nameSkill1 = "普通なパンチ";
			_nameSkill2 = "絶対防御";
			_nameSkill3 = "Detroit Smash";
			_physicalAttackMax = 100;
			_physicalAttackMin = 80;
			_physicalDefenseMax = 20;
			_physicalDefenseMin = 10;
			_magicalAttackMax = 30;
			_magicalAttackMin = 0;
			_magicalDefenseMax = 20;
			_magicalDefenseMin = 10;
		}
		public override void Skill1(List<AnimatedObject> AnmObj, Player player, string Direction)
		{
			List<int> xDelete = new List<int>();
			List<int> yDelete = new List<int>();
			if (player.Mp < 20)
				return;
			player.Mp -= 20;
			int x_1, y_1;
			int x_2, y_2;
			int x_3, y_3;
			int damage;

			if (Direction == "Up")
			{
				x_1 = player.X - 1;
				x_2 = player.X;
				x_3 = player.X + 1;
				y_1 = player.Y - 1;
				y_2 = player.Y - 1;
				y_3 = player.Y - 1;
			}
			else if (Direction == "Down")
			{
				x_1 = player.X - 1;
				x_2 = player.X;
				x_3 = player.X + 1;
				y_1 = player.Y + 1;
				y_2 = player.Y + 1;
				y_3 = player.Y + 1;
			}
			else if (Direction == "Left")
			{
				x_1 = player.X - 1;
				x_2 = player.X - 1;
				x_3 = player.X - 1;
				y_1 = player.Y - 1;
				y_2 = player.Y;
				y_3 = player.Y + 1;
			}
			else
			{
				x_1 = player.X + 1;
				x_2 = player.X + 1;
				x_3 = player.X + 1;
				y_1 = player.Y - 1;
				y_2 = player.Y;
				y_3 = player.Y + 1;
			}
			foreach (AnimatedObject a in AnmObj)
			{
				if ((a.X == x_1 && a.Y == y_1) || (a.X == x_2 && a.Y == y_2) || (a.X == x_3 && a.Y == y_3))
				{
					if (a is Player)
					{
						Player b = a as Player;

						damage = rnd.Next(_physicalAttackMin, _physicalAttackMax) * 2 - rnd.Next(b.CharacterChosen.PhysicalDefenseMin, b.CharacterChosen.PhysicalDefenseMax);
						if (damage > 0)
							b.Hp -= damage;
					}
					else if (a is Obstacle)
					{
						Obstacle b = a as Obstacle;
						damage = rnd.Next(_physicalAttackMin, _physicalAttackMax) * 2;
						if (damage > 0)
							b.Hp -= damage;
					}
					else if (a is Bomb)
					{
						Bomb b = a as Bomb;
						xDelete.Add(b.X);
						yDelete.Add(b.Y);
						b.Explode(AnmObj);
					}
				}
			}
			for (int a = 0; a < AnmObj.Count; a++)
			{
				for (int b = 0; b < xDelete.Count; b++)
				{
					if (AnmObj[a].X == xDelete[b] && AnmObj[a].Y == yDelete[b])
					{
						AnmObj.RemoveAt(a);
					}
				}
			}



		}
		public override void Skill2(List<AnimatedObject> AnmObj, Player player, string Direction)
		{
			List<int> xDelete = new List<int>();
			List<int> yDelete = new List<int>();
			if (player.Mp < 30)
				return;
			player.Mp -= 30;
			player.CharacterChosen.PhysicalDefenseMax = 500;
			player.CharacterChosen.PhysicalDefenseMin = 500;
			player.CharacterChosen.MagicalDefenseMax = 500;
			player.CharacterChosen.MagicalDefenseMin = 500;
		}
		public override void Skill3(List<AnimatedObject> AnmObj, Player player, string Direction)
		{
			int[] X = new int[9];
			int[] Y = new int[9];
			List<int> xDelete = new List<int>();
			List<int> yDelete = new List<int>();
			int index = 0;
			int damage;
			if (player.Mp < 80)
				return;
			player.Mp -= 80;
			//Set Attack Range
			for (int a = 0; a < 3; a++)
			{
				for (int b = 0; b < 3; b++)
				{
					if (Direction == "Up")
					{
						X[index] = (player.X - 1) + a;
						Y[index] = (player.Y - 1) - b;
					}
					else if (Direction == "Down")
					{
						X[index] = (player.X - 1) + a;
						Y[index] = (player.Y + 1) + b;
					}
					else if (Direction == "Left")
					{
						X[index] = (player.X - 1) - a;
						Y[index] = (player.Y - 1) + b;
					}
					else
					{
						X[index] = (player.X + 1) + a;
						Y[index] = (player.Y - 1) + b;
					}
					index++;
				}
			}

			for (int a = 0; a < 9; a++)
			{
				foreach (AnimatedObject b in AnmObj)
				{
					if (b.X == X[a] && b.Y == Y[a])
					{
						if (b is Player)
						{

							Player c = b as Player;
							damage = rnd.Next(_physicalAttackMin, _physicalAttackMax) * 3 - rnd.Next(c.CharacterChosen.PhysicalDefenseMin, c.CharacterChosen.PhysicalDefenseMax);
							if (damage > 0)
								c.Hp -= damage;

						}
						else if (b is Obstacle)
						{
							Obstacle c = b as Obstacle;
							damage = rnd.Next(_physicalAttackMin, _physicalAttackMax) * 3;
							if (damage > 0)
								c.Hp -= damage;
						}
						else if (b is Bomb)
						{
							Bomb c = b as Bomb;
							xDelete.Add(c.X);
							yDelete.Add(c.Y);
							c.Explode(AnmObj);
						}
					}
				}
			}
			for (int a = 0; a < AnmObj.Count; a++)
			{
				for (int b = 0; b < xDelete.Count; b++)
				{
					if (AnmObj[a].X == xDelete[b] && AnmObj[a].Y == yDelete[b])
					{
						AnmObj.RemoveAt(a);
					}
				}
			}

		}
	}
}

