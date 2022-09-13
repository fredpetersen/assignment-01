using System.Text.RegularExpressions;

namespace Assignment01;

public static class RegExpr
{
    public static IEnumerable<string> SplitLine(IEnumerable<string> lines)
    {
        foreach(var line in lines){
            foreach(var word in line.Split(" "))
            {
                yield return word;
            }
        }
    }

    public static IEnumerable<(int width, int height)> Resolutions(IEnumerable<string> resolutions)
    {

        var pattern = @"(?<width>\d+)x(?<height>\d+)";

        foreach(var resolution in resolutions)
        {
            foreach(Match match in Regex.Matches(resolution, pattern))
            {
                yield return (int.Parse(match.Groups["width"].Value), int.Parse(match.Groups["height"].Value));
            }
        }
    }

    public static IEnumerable<string> InnerText(string html, string tag) => throw new NotImplementedException();

    public static IEnumerable<(Uri url, string title)> Urls(string html) => throw new NotImplementedException();
}