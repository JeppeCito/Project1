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

        string filePath = Path.Combine(projectFolder, "text.txt");

        File.WriteAllText(filePath, text);

        return "Saved to project folder";
    }
}