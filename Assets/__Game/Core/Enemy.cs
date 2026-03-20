using System;
using UnityEditorInternal.Profiling.Memory.Experimental.FileFormat;
using UnityEngine;


namespace SpaceDefender.Core
{

    public class Enemy
    {
        public int Health;
        public int PointValue;
        public EnemyType Type;
        public bool IsAlive { get; }
        
        public void TakeDamage(int amount) { throw new NotImplementedException(); }
        public int GetReward() { throw new NotImplementedException(); }
    }

    public enum EnemyType
    {
        Basic,
        Fast,
        Tank
    }
}