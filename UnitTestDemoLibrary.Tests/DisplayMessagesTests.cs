using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

// Arrange,Act, Assert
// expected, actual

namespace UnitTestDemoLibrary.Tests
{
    public class DisplayMessagesTests
    {
        [Fact]
        public void GreetingShouldReturnGoodMorningMessage() {
            // Arrange
            DisplayMessage message = new DisplayMessage();
            string expected = "Good Morning, John!";

            // Act
            string actual = message.Greeting("John", 9);

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void GreetingShouldReturnGoodAfternoonMessage()
        {
            // Arrange
            DisplayMessage message = new DisplayMessage();
            string expected = "Good Afternoon, John!";
            // Act
            string actual = message.Greeting("John", 14);

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void GreetingShouldReturnGoodEveningMessage()
        {
            // Arrange
            DisplayMessage message = new DisplayMessage();
            string expected = "Good Evening, John!";
            // Act
            string actual = message.Greeting("John", 20);

            // Assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData("John", 0, "Good Morning, John!")]
        [InlineData("John", 1, "Good Morning, John!")]
        [InlineData("John", 2, "Good Morning, John!")]
        [InlineData("John", 3, "Good Morning, John!")]
        [InlineData("John", 4, "Good Morning, John!")]
        [InlineData("John", 5, "Good Morning, John!")]
        [InlineData("John", 6, "Good Morning, John!")]
        [InlineData("John", 7, "Good Morning, John!")]
        [InlineData("John", 8, "Good Morning, John!")]
        [InlineData("John", 9, "Good Morning, John!")]
        [InlineData("John", 10, "Good Morning, John!")]
        [InlineData("John", 11, "Good Morning, John!")]
        [InlineData("John", 12, "Good Afternoon, John!")]
        [InlineData("John", 13, "Good Afternoon, John!")]
        [InlineData("John", 14, "Good Afternoon, John!")]
        [InlineData("John", 15, "Good Afternoon, John!")]
        [InlineData("John", 16, "Good Afternoon, John!")]
        [InlineData("John", 17, "Good Afternoon, John!")]
        [InlineData("John", 18, "Good Evening, John!")]
        [InlineData("John", 19, "Good Evening, John!")]
        [InlineData("John", 20, "Good Evening, John!")]
        [InlineData("John", 21, "Good Evening, John!")]
        [InlineData("John", 22, "Good Evening, John!")]
        [InlineData("John", 23, "Good Evening, John!")]
        public void GreetingShouldReturnCorrectMessage(string name, int hour, string expected)
        {

            // Arrange
            DisplayMessage message = new DisplayMessage();
            // Act
            string actual = message.Greeting(name, hour);
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}


// ╔══════════════════════════════════════════════════════════════╗
// ║                    UNIT TESTING — xUnit                      ║
// ╚══════════════════════════════════════════════════════════════╝

// WHAT IS IT?
// Testing individual pieces (units) of code automatically.
// Proves your code works — no manual app running needed.
// Change code → run tests → pass/fail in seconds.

// ══════════════════════════════════════════════════════════════
// THE AAA PATTERN — EVERY TEST FOLLOWS THIS
// ══════════════════════════════════════════════════════════════
// [Fact]
// public void TestName()
// {
//     // ARRANGE — set up everything needed
//     var calc = new MathCalculation();
//     double expected = 5;
//
//     // ACT — run the thing you're testing
//     double actual = calc.Calc(2, 3, '+');
//
//     // ASSERT — did it return what you expected?
//     Assert.Equal(expected, actual);
// }

// ══════════════════════════════════════════════════════════════
// [Fact] vs [Theory]
// ══════════════════════════════════════════════════════════════
// [Fact]
// → One test, one fixed scenario
// → "This specific input always gives this specific output"

// [Theory]
// [InlineData(2, 3, '+', 5)]
// [InlineData(5, 4, '-', 1)]
// → Same test logic, multiple data sets
// → Runs once per InlineData row
// → Perfect for testing boundaries and multiple cases

// ══════════════════════════════════════════════════════════════
// NAMING CONVENTION — IMPORTANT
// ══════════════════════════════════════════════════════════════
// Formula: MethodName_Scenario_ExpectedResult
//
// ❌ vague:   CalcShouldReturnCorrect()
// ✅ clear:   Calc_AddTwoNumbers_ReturnsCorrectSum()
// ✅ clear:   Calc_DivideByZero_ThrowsDivideByZeroException()
// ✅ clear:   Greeting_HourBefore12_ReturnsGoodMorning()
//
// When 500 tests exist and one fails —
// the name tells you what broke without reading the code.

// ══════════════════════════════════════════════════════════════
// COMMON ASSERT METHODS
// ══════════════════════════════════════════════════════════════
// Assert.Equal(expected, actual)        → values are equal
// Assert.NotEqual(expected, actual)     → values are not equal
// Assert.True(condition)                → condition is true
// Assert.False(condition)               → condition is false
// Assert.Null(object)                   → object is null
// Assert.NotNull(object)                → object is not null
// Assert.Throws<Exception>(() => ...)   → method throws exception

// ══════════════════════════════════════════════════════════════
// HANDLING EXCEPTIONS IN TESTS
// ══════════════════════════════════════════════════════════════
// Never return a magic value for errors (like 69 for divide by zero)
// Throw a proper exception in the method:
//   throw new DivideByZeroException("Cannot divide by zero.");
//   throw new ArgumentException($"Invalid operator: {c}");
//
// Then test it with Assert.Throws:
// [Fact]
// public void Calc_DivideByZero_ThrowsDivideByZeroException()
// {
//     MathCalculation calc = new MathCalculation();
//     Assert.Throws<DivideByZeroException>(() => calc.Calc(10, 0, '/'));
// }
//
// () => is a lambda — wraps the method call so Assert.Throws
// can catch what comes out of it
// Throws correct exception  → test passes ✅
// Doesn't throw             → test fails  ❌
// Throws something else     → test fails  ❌

// ══════════════════════════════════════════════════════════════
// WHY THIS MATTERS FOR YOUR CAREER
// ══════════════════════════════════════════════════════════════
// Junior dev without tests  → "I think it works"
// Junior dev with tests     → "I can prove it works"
//
// Portfolio projects with tests = professionalism
// 90% of junior applicants don't write tests
// You will — that's your edge at Brain Station / KAZ interviews