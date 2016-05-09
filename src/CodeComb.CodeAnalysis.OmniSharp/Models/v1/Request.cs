using System.Collections.Generic;
using System.IO;

namespace CodeComb.CodeAnalysis.OmniSharp.Models
{
    public class Request
    {
        public int Line { get; set; }
        
        public int Column { get; set; }
        public string Buffer { get; set; }
        public IEnumerable<LinePositionSpanTextChange> Changes { get; set; }
        public string FileName { get; set; }
    }
}
