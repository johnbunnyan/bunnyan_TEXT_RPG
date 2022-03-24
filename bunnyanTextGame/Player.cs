using System;
using System.Collections.Generic;
using System.Text;

namespace bunnyanTextGame
{
    public enum PlyaerType
    {
        None = 0,
        Knight = 1,
        Archer = 2,
        Mage = 3
    }

    public class Player : Creature
    {
        protected PlyaerType type = PlyaerType.None;

        protected Player(PlyaerType type) : base(CreatureType.Player)
        {
            this.type = type;
        }

        public PlyaerType GetPlyaerType() { return type; }
    }

    class Knight : Player
    {
        public Knight() : base(PlyaerType.Knight)
        {
            SetInfo(100, 10);
        }
    }

    class Archer : Player
    {
        public Archer() : base(PlyaerType.Archer)
        {
            SetInfo(75, 12);
        }
    }

    class Mage : Player
    {
        public Mage() : base(PlyaerType.Mage)
        {
            SetInfo(50, 15);
        }
    }

}
