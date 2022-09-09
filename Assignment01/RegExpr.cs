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

    public static IEnumerable<(int width, int height)> Resolutions(IEnumerable<string> resolutions) => throw new NotImplementedException();
    {

        var pattern = @"(?<width>\d+)x(?<height>\d+)";


        foreach(var resolution in resolutions.Split(", "))
        {
            yield return resolution
        }
    }

    public static IEnumerable<string> InnerText(string html, string tag) => throw new NotImplementedException();
}