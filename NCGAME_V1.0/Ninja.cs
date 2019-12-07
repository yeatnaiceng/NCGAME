using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace NCGAME_V1._0
{
    class Ninja:Character
    {
		Random rnd = new Random();
		public Ninja()
		{
			_characterName = "Ninja";
			_hpState = 800;
			_mpState = 120;
			_mobility = 4;
			_nameSkill1 = "力上げる";
			_nameSkill2 = "スピードアップ";
			_nameSkill3 = "雷遁・麒麟";
			_physicalAttackMax = 50;
			_physicalAttackMin = 40;
			_physicalDefenseMax = 40;
			_physicalDefenseMin = 30;
			_magicalAttackMax = 40;
			_magicalAttackMin = 30;
			_magicalDefenseMax = 40;
			_magicalDefenseMin = 30;
		}
		public override void Skill1(List<AnimatedObject> AnmObj, Player player, string Direction)
		{
			player.Mp -= 30;
			player.CharacterChosen.PhysicalAttackMax += 10;
			player.CharacterChosen.PhysicalAttackMin += 10;
		}
		public override void Skill2(List<AnimatedObject> AnmObj, Player player, string Direction)
		{
			player.Mp -= 20;
			player.CharacterChosen.Mobility += 5;
		}
		public override void Skill3(List<AnimatedObject> AnmObj, Player player, string Direction)
		{
			int X;
			int Y;
			int damage;

			if (Direction == "Up")
			{
				X = player.X;
				Y = player.Y + 1;
			}
			else if (Direction == "Down")
			{
				X = player.X;
				Y = player.Y - 1;
			}
			else if (Direction == "Left")
			{
				X = player.X - 1;
				Y = player.Y;
			}
			else
			{
				X = player.X + 1;
				Y = player.Y;
			}

			foreach (AnimatedObject a in AnmObj)
			{
				if (a.X == X && a.Y == Y)
				{
					if (a is Player)
					{
						Player b = a as Player;
						damage = rnd.Next(_physicalAttackMin, _physicalAttackMax) * Mobility - rnd.Next(b.CharacterChosen.PhysicalDefenseMin, b.CharacterChosen.PhysicalDefenseMax);
						if (damage > 0)
							b.Hp -= damage;
					}
					else if (a is Obstacle)
					{
						Obstacle b = a as Obstacle;
						damage = rnd.Next(_physicalAttackMin, _physicalAttackMax) * Mobility;
						if (damage > 0)
							b.Hp -= damage;
					}
					else if (a is Bomb)
					{
						Bomb b = a as Bomb;
						b.Explode(AnmObj);
					}
				}
			}
		}

	}
}
