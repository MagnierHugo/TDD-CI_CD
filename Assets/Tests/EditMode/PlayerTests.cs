using NUnit.Framework;
using SpaceDefender.Core;

[TestFixture]
public class PlayerTests
{
    private Player _player;

    [SetUp]
    public void SetUp()
    {
        _player = new Player();   // Arrange - initialisation
    }

    // ---- ETAPE 1 : RED — ce test doit echouer ---------
    [Test]
    public void TakeDamage_Normal_ReducesHealth()
    {
        int damage = 20;

        _player.TakeDamage(damage);

        Assert.AreEqual(80, _player.Health);
    }

    [Test]
    public void TakeDamage_WithFatalDamage_SetsHealthToZero()
    {
        int damage = 100;

        _player.TakeDamage(damage);

        Assert.AreEqual(0, _player.Health);
    }

    [Test]
    public void TakeDamage_WithNegativeAmount_DoesNotChangeHealth()
    {
        int damage = -20;

        _player.TakeDamage(damage);

        Assert.AreEqual(100, _player.Health);
    }

    [Test]
    public void Heal_WhenHealthBelow100_IncreasesHealth()
    {
        _player.TakeDamage(50);

        int heal = 20;

        _player.Heal(heal);

        Assert.AreEqual(70, _player.Health);
    }

    [Test]
    public void Heal_WhenAlreadyFullHealth_DoesNotExceed100()
    {
        int heal = 20;

        _player.Heal(heal);

        Assert.AreEqual(100, _player.Health);
    }

    [Test]
    public void IsAlive_WhenHealthIsZero_ReturnsFalse()
    {
        _player.TakeDamage(100);

        Assert.IsFalse(_player.IsAlive);
    }

    [Test]
    public void LoseLife_WhenLastLife_IsAliveReturnsFalse()
    {
        _player.LoseLife();
        _player.LoseLife();
        _player.LoseLife();

        Assert.IsFalse(_player.IsAlive);
    }

}