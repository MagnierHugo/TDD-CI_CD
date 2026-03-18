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

    }

    [Test]
    public void ApplyCombo_With3Kills_IncreasesMultiplier()
    {

    }

    [Test]
    public void ResetMultiplier_AfterCombo_SetsMultiplierToOne()
    {

    }

    [Test]
    public void Calculate_AfterComboAndReset_UsesBaseMultiplier()
    {

    }
}
