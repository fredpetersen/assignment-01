namespace Assignment01.Tests;

public class IteratorTests
{
    [Fact]
    public void Flatten_when_given_stream_of_stream_of_int_returns_stream_of_int()
    {
        // Arrange
        var list = new List<List<int>>();
        list.Add(new List<int>(){1,2,3});
        list.Add(new List<int>(){4,5,6});

        // Act
        var result = Iterators.Flatten<int>(list);

        // Assert
        result.Should().BeEquivalentTo(new List<int>(){1,2,3,4,5,6});
    }

    [Fact]
    public void Filter_when_given_1_2_3_4_and_even_predicate_returns_2_4()
    {
        // Arrange
        var list = new List<int>(){1,2,3,4};

        // Act
        var result = Iterators.Filter<int>(list, i => i%2==0);

        // Assert
        result.Should().BeEquivalentTo(new List<int>(){2,4});
    }
}