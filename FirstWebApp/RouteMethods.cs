public static class RouteMethods
{
    public static string About() 
    {
        return "Проект, в котором нашлось место для статистики!";
    }
    public static string Hi(string name) 
    {
        string[] greetingOptions = {
            "Привет",
            "здравствуйте",
            "Доброго времени суток"
    
        };
        int ci = Random.Shared.Next(greetingOptions.Length);
        return $"{greetingOptions[ci]}, {name}!";
    }
    public static string Sum(int a, int b)
    {
        return $"{a} + {b} = {a + b}";
    }
}