using System.Collections.Generic;

namespace CodeComb.CodeAnalysis.OmniSharp.Models
{
    public class ModifiedFileResponse
    {
        public ModifiedFileResponse() { }

        public ModifiedFileResponse(string fileName)
        {
            FileName = fileName;
        }

        public string FileName { get; set; }
        public string Buffer { get; set; }
        public IEnumerable<LinePositionSpanTextChange> Changes { get; set; }
    }
}
