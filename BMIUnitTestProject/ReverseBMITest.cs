using Microsoft.VisualStudio.TestTools.UnitTesting;

using BMICalculator;

namespace BMIUnitTestProject
{
    [TestClass]
    public class ReverseBMITest
    {
        [TestMethod]
        public void TestTwentyBMI()
        {
            ReverseBMI reverseBMI = new ReverseBMI() { HeightFeet = 5, HeightInches = 5, DerisredBMI = 22 };
            Assert.AreEqual(reverseBMI.DesiredWeightStones, 9);
            Assert.AreEqual(reverseBMI.DesiredWeightPounds, 6);
        }
    }
}
