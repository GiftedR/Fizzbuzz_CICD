using FizzBuzz_Sample;

namespace kata_Tests
{
    [TestClass]
    public class FizzBuzz_Tests
    {
        [TestMethod]
        [DataRow(3)]
        [DataRow(7)]
        [DataRow(11)]
        public void FizzBuzz_Returns_ANumericRepresentationOfTheInputAsAString(int input)
        {
            // Arrage
            string result = "";

            // Act
            result = FizzBuzz_Library.FizzBuzz(input);

            // Assert
            Assert.IsInstanceOfType(result, typeof(string));
        }

        [TestMethod]
        [DataRow(3, "Fizz")]
        [DataRow(6, "Fizz")]
        [DataRow(12, "Fizz")]
        public void FizzBuzz_Returns_FizzWhenTheInputIsMultipleOf3(int input, string expected)
        {
            string result = "";

            result = FizzBuzz_Library.FizzBuzz(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(5, "Buzz")]
        [DataRow(10, "Buzz")]
        [DataRow(20, "Buzz")]
        public void FizzBuzz_Returns_BuzzWhenTheInputIsMultipleOf5(int input, string expected)
        {
            string result = "";

            result = FizzBuzz_Library.FizzBuzz(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(15, "FizzBuzz")]
        [DataRow(30, "FizzBuzz")]
        [DataRow(45, "FizzBuzz")]
        public void FizzBuzz_Returns_FizzBuzzWhenTheInputIsMultipleOf3and5(int input, string expected)
        {
            string result = "";

            result = FizzBuzz_Library.FizzBuzz(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(20, 4, 0)]
        [DataRow(17, 5, 2)]
        public void Mod_Returns_ResultOfInputAndModulo(int x, int y, int expected)
        {
            int output = 0;

            output = FizzBuzz_Library.Mod(x, y);

            Assert.AreEqual(expected, output);

        }
    }
}