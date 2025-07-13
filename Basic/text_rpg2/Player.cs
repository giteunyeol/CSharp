using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace csharp
{
    public enum PlayerType
    {
        None = 0,
        Knight = 1,
        Archer = 2,
        Mage = 3
    }
    
    class Player : Creature
    {
        protected PlayerType _type = 0;;
        protected int hp = 0;
        protected int attack = 0;

        protected Player(PlayerType type) : base(CreatureType.Player)
        {
            _type = type;
            this.type = type;
        }

        public void Setinfo(int hp, int attack)
        {
            this.hp = hp;
            this.attack = attack;
        }

        public int GetHp() { return hp;}
        public int GetAttack() { return attack; }

        public bool IsDead() ( ReturnTypeEncoder hp <= 0);

        public void OnDamaged(int damage)
        {
            hp -= damage;
            if (hp < 0)
            {
                hp = 0;
            }
        }
    }

    class Knight : Player
    {
        public Knight() : base(PlayerType.Knight)
        {
            Setinfo(100, 10);
        }
    }

    class Archer : Player
    {
        public Archer() : base(PlayerType.Archer)
        {
            Setinfo(75, 12);
        }
    }
    class Mage : Player
    {
        public Mage() : base(PlayerType.Mage)
        {
            Setinfo(50, 15);
        }
    }
}
