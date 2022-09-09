namespace Assignment01.Tests;

public class RegExprTests
{
    [Fact]
    public void SplitLines_when_given_lines_returns_words(){
        var lines = new List<string>{"Op til flere ord", "Et par ord her også"};

        var result = RegExpr.SplitLine(lines);

        result.Should().BeEquivalentTo(new List<string>(){"Op", "til", "flere", "ord", "Et", "par","ord","her","også"});
    }

    [Fact]
    public void Resolutions_when_given_lines_of_resolutions_returns_tuples_of_dimensions(){
        var resolutions = new List<string>(){"1920x1080", "1024x768, 800x600", "1280x960"};

        var result = RegExpr.Resolutions(resolutions);

        result.Should().BeEquivalentTo(new List<(int,int)>(){(1920, 1080),(1024,768),(800,600),(1280,960)});
    }
}