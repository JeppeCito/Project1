using MyMethods;


Console.Write("Hvilket ord vil du søge efter? ");
var wordInput = Console.ReadLine();

// Console.WriteLine("Indsæt den tekst du vil søge i: ");
// var textInput = Console.ReadLine();

var wordCount = new WordCount(wordInput!);
var count = wordCount.GetCount();

if (count.IsSuccess)
{
    Console.WriteLine($"'{wordInput}' was found {count.Value} times");
    Console.WriteLine(SaveToFile.Save(wordCount.GetText()));

}
else
{
    Console.WriteLine($"Error: {count.Error}");

}

// Console.WriteLine($"countOutput: {countOutput}");

// if (countOutput == null)
// {
//     Console.WriteLine("Det søgte ord findes ikke i det angivne tekst");
// }
// if (countOutput == false)
// {
//     Console.WriteLine($"Ordet {wordInput} forekommer {count} gange.");
// }
// if (countOutput == true)
// {
//     Console.WriteLine($"Ordet {wordInput} forekommer {count} gange.");

//     string userFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
//     string filePath = Path.Combine(userFolder, "text.txt");

//     // Console.WriteLine(SaveToFile.Save(filePath, wordCount.GetText()));

// }