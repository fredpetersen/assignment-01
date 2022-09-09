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

        var result = Iterators.Flatten<int>(list);

        result.Should().BeEquivalentTo(new List<int>(){1,2,3,4,5,6});

    }
}