public class SaveToFile
{
    public static string Save(string filePath, string text)
    {
        File.WriteAllText(filePath, text);

        return $"Saved to {filePath}";
    }

    public static string Save(string text)
    {
        string projectFolder = Directory.GetParent(AppContext.BaseDirectory).Parent.Parent.Parent.FullName;

        Console.WriteLine($"Get Parent: {Directory.GetParent(AppContext.BaseDirectory)}");
        Console.WriteLine($"Single .parent: {Directory.GetParent(AppContext.BaseDirectory).Parent}");
        Console.WriteLine($"Two .parent: {Directory.GetParent(AppContext.BaseDirectory).Parent.Parent}");
        Console.WriteLine($"Three .parent: {Directory.GetParent(AppContext.BaseDirectory).Parent.Parent.Parent}");



        string filePath = Path.Combine(projectFolder, "text.txt");

        File.WriteAllText(filePath, text);

        return "Saved to project folder";
    }
}