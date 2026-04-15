namespace MyMethods;

internal class WordCount
{
    private string _word;
    private string _text;

    public WordCount(string word, string text)
    {
        _word = word;
        _text = text;
    }

    public WordCount(string word)
    {
        _word = word;
        _text = """
                Built-in types and custom types
                C# provides built-in types for common data: integers, floating-point numbers, bool, char, and string. Every C# program can use these built-in types without any extra references.
                Beyond built-in types, you can create your own types by using several constructs:
                Classes — Reference types for modeling behavior and complex objects. Support inheritance and polymorphism.
                Structs — Value types for small, lightweight data. Each variable holds its own copy.
                Records — Classes or structs with compiler-generated equality, ToString, and nondestructive mutation through with expressions.
                Interfaces — Contracts that define members any class or struct can implement.
                Enumerations — Named sets of integral constants, such as days f the week or file access modes.
                Tuples — Lightweight structural types that group related values without defining a named type.
                Generics — Type-parameterized constructs like List<T> and Dictionary<TKey, TValue> that provide type safety while reusing the same logic for different types.
                """;
    }

    public string GetText()
    {
        return _text;
    }

    public int GetCount()
    {
        string wordToLower = _word.ToLower();
        string textToLower = _text.ToLower();

        int count = 0;

        var wordList = textToLower.Split(" ");

        foreach (var tempWord in wordList)
        {
            if (tempWord.Contains(wordToLower))
            {
                count++;
            }
        }

        return count;
    }

    public bool? CountOutput(int count)
    {
        if (count == 0)
        {
            return null;
        }
        else if (count >= 1 && count < 10)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}