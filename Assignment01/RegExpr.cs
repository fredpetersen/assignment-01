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

    public static IEnumerable<string> InnerText(string html, string tag)
    {
        var pattern = @"<(" + tag + @").*?>(?<innerText>.*?)<\/\1>";

        foreach (Match match in Regex.Matches(html, pattern))
	    {
            yield return Regex.Replace(match.Groups["innerText"].Value, @"(<[^][^>]*>)", "");
	    }
    }

    

    public static IEnumerable<(Uri url, string title)> Urls(string html)
    {
        var pattern = @"href=""(?<url>.*?)"".*?(?:(?:title=""(?<title>.*?)"")|(?:>(?<innerText>.*?)<\/a>))";

        foreach(Match match in Regex.Matches(html, pattern))
        {
            if(match.Groups["title"].Value != "")
            {
                yield return (new Uri(match.Groups["url"].Value), match.Groups["title"].Value);
            }
            else
            {
                yield return (new Uri(match.Groups["url"].Value), match.Groups["innerText"].Value);
            }
            
        }
    }

}