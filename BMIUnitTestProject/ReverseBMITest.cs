using Microsoft.VisualStudio.TestTools.UnitTesting;

using BMICalculator;

namespace BMIUnitTestProject
{
    [TestClass]
    public class ReverseBMITest
    {
        [TestMethod]
        public void TestTwentyTwoBMI()
        {
            ReverseBMI reverseBMI = new ReverseBMI() { HeightFeet = 5, HeightInches = 5, DerisredBMI = 22 };
            Assert.AreEqual(reverseBMI.DesiredWeightStones, 9);
            Assert.AreEqual(reverseBMI.DesiredWeightPounds, 6);
        }

        [TestMethod]
        public void TestTwentyFourBMI()
        {
            ReverseBMI reverseBMI = new ReverseBMI() { HeightFeet = 6, HeightInches = 2, DerisredBMI = 24 };
            Assert.AreEqual(reverseBMI.DesiredWeightStones, 13);
            Assert.AreEqual(reverseBMI.DesiredWeightPounds, 4);
        }

        [TestMethod]
        public void TestTwentyBMI()
        {
            ReverseBMI reverseBMI = new ReverseBMI() { HeightFeet = 5, HeightInches = 5, DerisredBMI = 20 };
            Assert.AreEqual(reverseBMI.DesiredWeightStones, 7);
            Assert.AreEqual(reverseBMI.DesiredWeightPounds, 4);
        }
    }
}
