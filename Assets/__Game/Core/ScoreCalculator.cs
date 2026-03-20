using System;
using System.Diagnostics;
using UnityEngine;


namespace SpaceDefender.Core
{

    public class ScoreCalculator
    {
        public int BaseScore;
        public float Multiplier;

        public int Calculate(int kills, int time) { throw new NotImplementedException(); }
        public void ApplyCombo(int comboCount) { throw new NotImplementedException(); }
        public void ResetMultiplier() { throw new NotImplementedException(); }
    }

}