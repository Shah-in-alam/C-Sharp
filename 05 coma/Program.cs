using System;

class PunctuationCorrector
{
    static void Main()
    {
        string inputSentence = Console.ReadLine();

        char[] outputChars = new char[inputSentence.Length];
        int outputIndex = 0;
        char lastChar = '\0';

        foreach (char currentChar in inputSentence)
        {
            
            if (currentChar == ' ' && (lastChar == ' ' || outputIndex == 0))
            {
                continue;
            }
            if (lastChar == currentChar && (currentChar == '\'' || currentChar == '"' || currentChar == '.' || currentChar == '?' || currentChar == '!'|| currentChar==':'))
            {
                continue;
            }
            if (currentChar == '{' || currentChar == '}' || currentChar == '[' || currentChar == ']' || currentChar == '(' || currentChar == ')')
            {
                if (lastChar != currentChar)
                {
                    outputChars[outputIndex++] = currentChar;
                }
                lastChar = currentChar;
                continue;
            }
            if (outputIndex == 0 || lastChar != ' ' || currentChar != ' ')
            {
                outputChars[outputIndex++] = currentChar;
            }

            lastChar = currentChar;
        }

        string correctedSentence = new string(outputChars, 0, outputIndex).TrimEnd();
        Console.WriteLine(correctedSentence);
    }
}
