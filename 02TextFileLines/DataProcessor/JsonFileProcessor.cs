using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DataProcessor
{
    public class JsonFileProcessor
    {
        public string InputFilePath { get; }
        public string OutputFilePath { get; }

        public JsonFileProcessor(string inputFilePath, string outputFilePath)
        {
            InputFilePath = inputFilePath;
            OutputFilePath = outputFilePath;
        }

        public void Process()
        {
            // Using read all text
            //string originalText = File.ReadAllText(InputFilePath);
            //string processedText = originalText.ToUpperInvariant();
            //File.WriteAllText(OutputFilePath, processedText);

            // Using read all lines
            string[] lines = File.ReadAllLines(InputFilePath);
            lines[1] = lines[1].ToUpperInvariant(); // Assumes there is a line 2 in the file
            File.WriteAllLines(OutputFilePath, lines);
        }
    }
}
