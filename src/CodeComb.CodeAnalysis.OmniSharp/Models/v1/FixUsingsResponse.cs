using System.Collections.Generic;

namespace CodeComb.CodeAnalysis.OmniSharp.Models
{
    public class FixUsingsResponse
    {
        public string Buffer { get; set; }
        public IEnumerable<QuickFix> AmbiguousResults { get; set; }
        public IEnumerable<LinePositionSpanTextChange> Changes { get; set; }
    }
}
