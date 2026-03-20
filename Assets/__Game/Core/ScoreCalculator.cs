using System;
using System.Diagnostics;
using UnityEngine;


namespace SpaceDefender.Core
{

    public class ScoreCalculator
    {
        public int BaseScore;
        public float Multiplier;

        public int Calculate(int kills, int time) => (int)(kills * BaseScore * Multiplier);
        public void ApplyCombo(int comboCount) => Multiplier = comboCount > 1 ? comboCount - 1 : 1.0f;
        public void ResetMultiplier() => Multiplier = 1.0f;
    }

}