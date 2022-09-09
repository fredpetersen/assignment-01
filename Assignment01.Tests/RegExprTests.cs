namespace Assignment01.Tests;

public class RegExprTests
{
    [Fact]
    public void SplitLines_when_given_lines_returns_words(){
        var lines = new List<string>{"Op til flere ord", "Et par ord her også"};

        var result = RegExpr.SplitLine(lines);

        result.Should().BeEquivalentTo(new List<string>(){"Op", "til", "flere", "ord", "Et", "par","ord","her","også"});
    }
}