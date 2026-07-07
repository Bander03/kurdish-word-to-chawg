using System;
using System.IO;
using System.Text;

string inputFile = "input.txt";
string outputFile = "output.txt";

Console.WriteLine("=== GendeStemmer File Processor ===");

// 1. Check if the input file exists
if (!File.Exists(inputFile))
{
    Console.WriteLine($"Error: '{inputFile}' not found.");
    Console.WriteLine("Please create an 'input.txt' file in this folder and add your Kurdish text.");
    return;
}

// 2. Read the text from the file using UTF-8 encoding
string text = File.ReadAllText(inputFile, Encoding.UTF8).Trim();
Console.WriteLine("Processing text from input.txt...");

if (string.IsNullOrWhiteSpace(text))
{
    Console.WriteLine("The input file is empty.");
    return;
}

// 3. Stem the text
string stemmedText;
if (!text.Contains(" "))
{
    // Single word
    stemmedText = GendeStemmer.Stemmer.StemWord(text);
}
else
{
    // Multiple words / Sentences
    stemmedText = GendeStemmer.Stemmer.Stem(text);
}

// 4. Save the results to an output file
File.WriteAllText(outputFile, stemmedText, Encoding.UTF8);

Console.WriteLine("✅ Done! Open 'output.txt' to see the stemmed results.");