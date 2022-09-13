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
    public void Resolutions_when_given_lines_of_resolutions_returns_tuples_of_dimensions()
    {
        var resolutions = new List<string>(){"1920x1080", "1024x768, 800x600", "1280x960"};

        var result = RegExpr.Resolutions(resolutions);

        result.Should().BeEquivalentTo(new List<(int,int)>(){(1920, 1080),(1024,768),(800,600),(1280,960)});
    }

    [Fact]
    public void InnerText_when_given_html_returns_inner_text()
    {
        var html = "<div> <p>A <b>regular expression</b>, <b>regex</b> or <b>regexp</b> (sometimes called a <b>rational expression</b>) is, in <a href=\"https://en.wikipedia.org/wiki/Theoretical_computer_science\" title=\"Theoretical computer science\">theoretical computer science</a> and <a href=\"https://en.wikipedia.org/wiki/Formal_language\" title=\"Formal language\">formal language</a> theory, a sequence of <a href=\"https://en.wikipedia.org/wiki/Character_(computing)\" title=\"Character (computing)\">characters</a> that define a <i>search <a href=\"https://en.wikipedia.org/wiki/Pattern_matching\" title=\"Pattern matching\">pattern</a></i>. Usually this pattern is then used by <a href=\"https://en.wikipedia.org/wiki/String_searching_algorithm\" title=\"String searching algorithm\">string searching algorithms</a> for \"find\" or \"find and replace\" operations on <a href=\"https://en.wikipedia.org/wiki/String_(computer_science)\" title=\"String (computer science)\">strings</a>.</p> </div>";
    
        var result = RegExpr.InnerText(html, "a");

        result.Should().BeEquivalentTo(new List<string>(){"theoretical computer science","formal language", "characters", "pattern", "string searching algorithms","strings"});
    }
}