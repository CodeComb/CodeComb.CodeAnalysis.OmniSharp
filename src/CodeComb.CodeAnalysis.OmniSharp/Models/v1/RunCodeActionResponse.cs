using System.Collections.Generic;

namespace CodeComb.CodeAnalysis.OmniSharp.Models
{
    public class RunCodeActionResponse
    {
        public string Text { get; set; }
        public IEnumerable<LinePositionSpanTextChange> Changes { get; set; }
    }
}
