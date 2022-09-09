namespace Assignment01;

public static class Iterators
{
    public static IEnumerable<T> Flatten<T>(IEnumerable<IEnumerable<T>> items)
    {
        var result = new List<T>();

        foreach(var enumerable in items)
        {
            foreach(var item in enumerable){
                result.Add(item);
            }
        }
        return result;
    }

    public static IEnumerable<T> Filter<T>(IEnumerable<T> items, Predicate<T> predicate) => throw new NotImplementedException();

    private static void Main(string[] args){
        System.Console.WriteLine("Hello world");
    }
}