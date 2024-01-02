using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.Tests;

public class GroupingTests
{
    
    [Test]
    public void Test_GroupNumbers_WithEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<int> nums = new List<int>();

        // Act
        string result = Grouping.GroupNumbers(nums);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_GroupNumbers_WithEvenAndOddNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> nums = new List<int>() {1, 2, 6, 11 };

        // Act
        string result = Grouping.GroupNumbers(nums);

        // Assert
        Assert.That(result, Is.EqualTo("Odd numbers: 1, 11\r\nEven numbers: 2, 6"));

    }

    [Test]
    public void Test_GroupNumbers_WithOnlyEvenNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> nums = new List<int>() { 2, 6, 10 };

        // Act
        string result = Grouping.GroupNumbers(nums);

        // Assert
        Assert.That(result, Is.EqualTo("Even numbers: 2, 6, 10"));

    }

    [Test]
    public void Test_GroupNumbers_WithOnlyOddNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> nums = new List<int>() { 9, 11, 13 };

        // Act
        string result = Grouping.GroupNumbers(nums);

        // Assert
        Assert.That(result, Is.EqualTo("Odd numbers: 9, 11, 13"));

    }

    [Test]
    public void Test_GroupNumbers_WithNegativeNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> nums = new List<int>() { -2, -9 };

        // Act
        string result = Grouping.GroupNumbers(nums);

        // Assert
        Assert.That(result, Is.EqualTo("Even numbers: -2\r\nOdd numbers: -9"));
    }
}
