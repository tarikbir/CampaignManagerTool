using NUnit.Framework;

namespace CampaignManagerUnitTests
{
    class StatSystemTest : TestBase
    {
        StatSystem stats;

        [SetUp]
        public void Setup()
        { }

        [Test]
        public void Check_modifiers()
        {
            stats = new StatSystem(10, 10, 10, 10, 10, 10);

            Assert.AreEqual(stats.CalculateModifier(1), -5);
            Assert.AreEqual(stats.CalculateModifier(4), -3);
            Assert.AreEqual(stats.CalculateModifier(8), -1);
            Assert.AreEqual(stats.CalculateModifier(12), 1);
            Assert.AreEqual(stats.CalculateModifier(17), 3);
            Assert.AreEqual(stats.CalculateModifier(29), 9);
        }

        [Test]
        public void Increase_modifiers()
        {
            stats = new StatSystem(1, 4, 8, 12, 15, 29);

            stats.IncreaseStat(CharacterStat.INT, 3);

            Assert.AreEqual(stats.GetStat(CharacterStat.INT).Value, 15);
        }

        [Test]
        public void Value_limits()
        {
            stats = new StatSystem(1, 1, 1, 30, 30, 30);

            stats.IncreaseStat(CharacterStat.STR, -1);
            stats.IncreaseStat(CharacterStat.CHA, 1);

            Assert.AreEqual(stats.GetStat(CharacterStat.STR).Value, 1);
            Assert.AreEqual(stats.GetStat(CharacterStat.CHA).Value, 30);
        }
    }
}
