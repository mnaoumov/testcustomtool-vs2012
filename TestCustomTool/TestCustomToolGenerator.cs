using System;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualStudio.TextTemplating.VSHost;

namespace TestCustomTool
{
    [ComVisible(true)]
    // TODO: Replace with your GUID
    [Guid("3B850477-71D3-4916-A3A3-D1BD0749BFAA")]
    public class TestCustomToolGenerator : BaseCodeGeneratorWithSite
    {
        public override string GetDefaultExtension()
        {
            // TODO: Replace with your implementation
            return ".test.txt";
        }

        protected override byte[] GenerateCode(string inputFileName, string inputFileContent)
        {
            // TODO: Replace with your implementation
            var generatedText = string.Format(@"{1}{0}{0}Filename: {2}{0}{0}Timestamp: {3}", Environment.NewLine, inputFileContent, inputFileName, DateTime.Now);
            return Encoding.UTF8.GetBytes(generatedText);
        }
    }
}