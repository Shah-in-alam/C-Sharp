using System;

class IsogramChecker
{
    static void Main()
    {
        Console.Write("");
        string inputWord = Console.ReadLine();

        bool isIsogram = CheckIsogram(inputWord);
        Console.WriteLine(isIsogram ? "True" : "False");
    }

    static bool CheckIsogram(string word)
    {
        // Convert all characters to lowercase to handle case-insensitivity
        word = word.ToLower();

        // Create an array to track the letters
        bool[] seen = new bool[26]; // 26 letters in the English alphabet

        foreach (char c in word)
        {
            // Ignore non-letter characters
            if (!char.IsLetter(c))
                continue;

            int index = c - 'a'; // Convert character to index (0-25)

            if (seen[index])
                return false; // We've seen this letter before, so it's not an isogram

            seen[index] = true; // Mark this letter as seen
        }

        return true; // No letter was repeated, so it's an isogram
    }
}
