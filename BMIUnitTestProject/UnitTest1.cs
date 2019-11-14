using Microsoft.VisualStudio.TestTools.UnitTesting;

using BMICalculator;

namespace BMIUnitTestProject
{
    [TestClass]
    public class BMITests
    {
        [TestMethod]
        public void TestNormalBMI()
        {
            BMI bmi = new BMI() { WeightStones = 12, WeightPounds = 0, HeightFeet = 5, HeightInches = 10 };
            Assert.AreEqual(bmi.BMICategory, BMICategory.Normal);
        }

        [TestMethod]
        public void TestObeseBMI()
        {
            BMI bmi = new BMI() { WeightStones = 15, WeightPounds = 0, HeightFeet = 5, HeightInches = 10 };
            Assert.AreEqual(bmi.BMICategory, BMICategory.Obese);
        }

        [TestMethod]
        public void TestUnderweightBMI()
        {
            BMI bmi = new BMI() { WeightStones = 7, WeightPounds = 0, HeightFeet = 5, HeightInches = 10 };
            Assert.AreEqual(bmi.BMICategory, BMICategory.Underweight);
        }

        [TestMethod]
        public void TestOverweightBMI()
        {
            BMI bmi = new BMI() { WeightStones = 11, WeightPounds = 0, HeightFeet = 5, HeightInches = 5 };
            Assert.AreEqual(bmi.BMICategory, BMICategory.Overweight);
        }
    }
}
