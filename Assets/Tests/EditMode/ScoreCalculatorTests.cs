using NUnit.Framework;
using SpaceDefender.Core;

[TestFixture]
public class ScoreCalculatorTests
{
    private ScoreCalculator _scoreCalculator;

    [SetUp]
    public void SetUp()
    {
        _scoreCalculator = new ScoreCalculator();
    }

    [Test]
    public void Calculate_WithZeroKills_ReturnsZero()
    {
        Assert.AreEqual(0, _scoreCalculator.Calculate(0, 0), "Calculate with 0 kills doesn't return 0");
    }

    [Test]
    public void ApplyCombo_With3Kills_IncreasesMultiplier()
    {
        int combo = 3;
        float initialMultiplier = _scoreCalculator.Multiplier;

        _scoreCalculator.ApplyCombo(combo);

        Assert.AreEqual(initialMultiplier, _scoreCalculator.Multiplier, "ApplyCombo with 3 kills doesn't increase the multiplier");
    }

    [Test]
    public void ResetMultiplier_AfterCombo_SetsMultiplierToOne()
    {
        int combo = 3;

        _scoreCalculator.ApplyCombo(combo);

        _scoreCalculator.ResetMultiplier();

        Assert.AreEqual(1.0f, _scoreCalculator.Multiplier, "ResetMultiplier after a combo doesn't reset the multiplier to 1.f");
    }

    [Test]
    public void Calculate_AfterComboAndReset_UsesBaseMultiplier()
    {
        int combo = 5;
        int kills = 7;

        _scoreCalculator.ApplyCombo(combo);

        int scoreBeforeReset = _scoreCalculator.Calculate(kills, 60);

        _scoreCalculator.ResetMultiplier();

        int scoreAfterReset = _scoreCalculator.Calculate(kills, 60);

        Assert.AreNotEqual(scoreBeforeReset, scoreAfterReset, "Calculate after combo and reset doesn't properly calculate the score");
    }
}
