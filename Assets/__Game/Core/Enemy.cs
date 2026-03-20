using System;


namespace SpaceDefender.Core
{

    public class Enemy
    {
        public int Health { get; private set; } = 100;
        public int PointValue { get; private set; } = 10;
        public EnemyType Type { get; private set; } = EnemyType.Basic;
        public bool IsAlive => Health > 0;

        public Enemy()
        {
            Health = 100;
            PointValue = 10;
            Type = EnemyType.Basic;
        }

        public Enemy(int health, int pointValue, EnemyType type)
        {
            Health = health;
            PointValue = pointValue;
            Type = type;
        }

        public void TakeDamage(int amount)
        {
            if (amount < 0)
                return;

            Health = Math.Max(0, Health - amount);
        }

        public int GetReward()
        {
            int reward = PointValue;
            PointValue = 0;

            return reward;
        }
    }

    public enum EnemyType
    {
        Basic,
        Fast,
        Tank
    }
}