using System;
using System.Text;

class PunctuationCorrector
{
    static void Main()
    {
        Console.WriteLine("Enter a sentence to correct punctuation:");
        string inputSentence = Console.ReadLine();

        string correctedSentence = CorrectPunctuation(inputSentence);
        Console.WriteLine("Corrected Sentence:");
        Console.WriteLine(correctedSentence);
    }

    static string CorrectPunctuation(string sentence)
    {
        // Define punctuation symbols that should not be preceded by a space
        char[] punctuationsNoPrecedingSpace = new char[] { '.', ',', '?', '!', ':', ';', ')' };
        StringBuilder corrected = new StringBuilder();
        char lastChar = '\0';

        for (int i = 0; i < sentence.Length; i++)
        {
            char c = sentence[i];
            // If the current character is a punctuation that should not be preceded by a space
            if (Array.IndexOf(punctuationsNoPrecedingSpace, c) >= 0)
            {
                // Remove any space if it's before the punctuation
                if (corrected.Length > 0 && corrected[corrected.Length - 1] == ' ')
                {
                    corrected.Remove(corrected.Length - 1, 1);
                }

                // If the last character is the same as the current, skip it
                if (c == lastChar) continue;
            }
            // Check if the current character is any other punctuation
            else if (Array.IndexOf(punctuationsNoPrecedingSpace, lastChar) >= 0 && c == ' ')
            {
                // If the last character was a punctuation that should not be followed by a space, skip the space
                continue;
            }

            corrected.Append(c);
            lastChar = c; // Set the last character to the current one
        }

        // Trim spaces before punctuation marks and ensure the sentence ends with a period if it does not end with other ending punctuations
        string result = corrected.ToString().TrimEnd(new char[] { ' ', '.', ',', '?', '!', ':', ';', '-' });

        // Add a period at the end if it's missing and the sentence doesn't end with another punctuation
        if (!result.EndsWith(".") && !result.EndsWith("?") && !result.EndsWith("!"))
        {
            result += ".";
        }

        return result;
    }
}