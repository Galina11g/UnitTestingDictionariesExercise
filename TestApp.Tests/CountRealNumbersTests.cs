using NUnit.Framework;

using System;
using System.Text;

namespace TestApp.Tests;

public class CountRealNumbersTests
{

    [Test]
    public void Test_Count_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        int[] nums = Array.Empty<int>();

        // Act
        string result = CountRealNumbers.Count(nums);
        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Count_WithSingleNumber_ShouldReturnCountString()
    {
        int[] nums = new int[] {5};

        // Act
        string result = CountRealNumbers.Count(nums);
        
        // Assert
        Assert.That(result, Is.EqualTo("5 -> 1"));
    }

    [Test]
    public void Test_Count_WithMultipleNumbers_ShouldReturnCountString()
    {
        int[] nums = new int[6] { 5, 4, 5, 9, 11, 11 };

        StringBuilder sb = new StringBuilder();
        sb.AppendLine("4 -> 1");
        sb.AppendLine("5 -> 2");
        sb.AppendLine("9 -> 1");
        sb.AppendLine("11 -> 2");

        string expected = sb.ToString().Trim();

        // Act
        string result = CountRealNumbers.Count(nums);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithNegativeNumbers_ShouldReturnCountString()
    {
       
            int[] nums = new int[5] { -5, 4, 5, -9, -9 };

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("-9 -> 2");
            sb.AppendLine("-5 -> 1");
            sb.AppendLine("4 -> 1");
            sb.AppendLine("5 -> 1");

            string expected = sb.ToString().Trim();

            // Act
            string result = CountRealNumbers.Count(nums);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

    [Test]
    public void Test_Count_WithZero_ShouldReturnCountString()
    {
        int[] nums = new int[] { 0, 0, 0 };

        // Act
        string result = CountRealNumbers.Count(nums);

        // Assert
        Assert.That(result, Is.EqualTo("0 -> 3"));
    }
}
