using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp.Tests;

public class CountCharactersTests
{
    [Test]
    public void Test_Count_WithEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<string> input = new();

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.Empty);
    }


    [Test]
    public void Test_Count_WithNoCharacters_ShouldReturnEmptyString()
    {
        // Arrange
        List<string> input = new() { "", "", "" };

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Count_WithSingleCharacter_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() { "aaa" };

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.EquivalentTo("a -> 3"));
    }

    [Test]
    public void Test_Count_WithMultipleCharacters_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() { "aaa", "bb", "cbb" };

        StringBuilder sb = new StringBuilder();
        sb.AppendLine("a -> 3");
        sb.AppendLine("b -> 4");
        sb.AppendLine("c -> 1");

        string expected = sb.ToString().Trim();


        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithSpecialCharacters_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() { "aa!a", "bb", "cb!b.,,," };

        StringBuilder sb = new StringBuilder();
        sb.AppendLine("a -> 3");
        sb.AppendLine("! -> 2");
        sb.AppendLine("b -> 4");
        sb.AppendLine("c -> 1");
        sb.AppendLine(". -> 1");
        sb.AppendLine(", -> 3");

        string expected = sb.ToString().Trim();


        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithUpperlCharactersAndNumbers_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() { "G11", "Gb", "G" };

        StringBuilder sb = new StringBuilder();
        sb.AppendLine("G -> 3");
        sb.AppendLine("1 -> 2");
        sb.AppendLine("b -> 1");


        string expected = sb.ToString().Trim();


        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
