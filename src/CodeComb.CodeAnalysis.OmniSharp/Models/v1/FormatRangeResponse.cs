using System.Collections.Generic;

namespace CodeComb.CodeAnalysis.OmniSharp.Models
{
    public class FormatRangeResponse
    {
        public IEnumerable<LinePositionSpanTextChange> Changes { get; set; }
    }
}