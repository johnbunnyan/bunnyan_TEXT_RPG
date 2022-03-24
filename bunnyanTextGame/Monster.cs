using System;
using System.Collections.Generic;
using System.Text;

namespace bunnyanTextGame
{
    public enum MonsterType
    {
        None = 0,
        Slime = 1,
        Orc = 2,
        Skeleton = 3
    };

    public class Monster : Creature
    {
        protected MonsterType Type;
        protected Monster(MonsterType type) : base(CreatureType.Monster)
        {
            this.Type = type;
        }
       public MonsterType GetMonsterType() { return Type; }
    }

    class Slime : Monster
    {
        public Slime() : base(MonsterType.Slime)
        {
            SetInfo(10, 10);
        }
    }

    class Orc : Monster
    {
        public Orc() : base(MonsterType.Orc)
        {
            SetInfo(20, 15);
        }
    }

    class Skeleton : Monster
    {
        public Skeleton() : base(MonsterType.Skeleton)
        {
            SetInfo(15, 25);
        }
    }
}
