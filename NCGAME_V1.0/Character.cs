using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCGAME_V1._0
{
    public abstract class Character
    {
		protected string _characterName;
		protected int _hpState;
		protected int _mpState;
		protected int _mobility;
		protected string _nameSkill1;
		protected string _nameSkill2;
		protected string _nameSkill3;
		protected int _physicalAttackMax;
		protected int _physicalAttackMin;
		protected int _physicalDefenseMax;
		protected int _physicalDefenseMin;
		protected int _magicalAttackMax;
		protected int _magicalAttackMin;
		protected int _magicalDefenseMax;
		protected int _magicalDefenseMin;

		public Character()
		{
			_characterName = null;
			_hpState = 0;
			_mpState = 0;
			_mobility = 0;
			_nameSkill1 = null;
			_nameSkill2 = null;
			_nameSkill3 = null;
			_physicalAttackMax = 0;

		}

		public string CharacterName
		{
			get { return _characterName; }
			set { _characterName = value; }
		}

		public int HpState
		{
			get { return _hpState; }
			set { _hpState = value; }
		}

		public int MpState
		{
			get { return _mpState; }
			set { _mpState = value; }
		}

		public int Mobility
		{
			get { return _mobility; }
			set { _mobility = value; }
		}

		public string NameSkill1
		{
			get { return _nameSkill1; }
			set { _nameSkill1 = value; }
		}

		public string NameSkill2
		{
			get { return _nameSkill2; }
			set { _nameSkill2 = value; }
		}

		public string NameSkill3
		{
			get { return _nameSkill3; }
			set { _nameSkill3 = value; }
		}

		public int PhysicalAttackMax
		{
			get { return _physicalAttackMax; }
			set { _physicalAttackMax = value; }
		}

		public int PhysicalAttackMin
		{
			get { return _physicalAttackMin; }
			set { _physicalAttackMin = value; }
		}

		public int PhysicalDefenseMax
		{
			get { return _physicalDefenseMax; }
			set { _physicalDefenseMax = value; }
		}

		public int PhysicalDefenseMin
		{
			get { return _physicalDefenseMin; }
			set { _physicalDefenseMin = value; }
		}

		public int MagicalAttackMax
		{
			get { return _magicalAttackMax; }
			set { _magicalAttackMax = value; }
		}

		public int MagicalAttackMin
		{
			get { return _magicalAttackMin; }
			set { _magicalAttackMin = value; }
		}
		public int MagicalDefenseMax
		{
			get { return _magicalDefenseMax; }
			set { _magicalDefenseMax = value; }
		}
		public int MagicalDefenseMin
		{
			get { return _magicalDefenseMin; }
			set { _magicalDefenseMin = value; }
		}

		public abstract void Skill1(List<AnimatedObject> AnmObj, Player player, string Direction);
		public abstract void Skill2(List<AnimatedObject> AnmObj, Player player, string Direction);
		public abstract void Skill3(List<AnimatedObject> AnmObj, Player player, string Direction);
	}
}
