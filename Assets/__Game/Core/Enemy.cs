using System;


namespace SpaceDefender.Core
{

    public class Enemy
    {
        public int Health;
        public int PointValue;
        public EnemyType Type;
        public bool IsAlive => Health > 0;
        
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