using System.Collections.Generic;

namespace CodeComb.CodeAnalysis.OmniSharp.Models
{
    public class GetCodeActionsResponse
    {
        public IEnumerable<string> CodeActions { get; set; }
    }
}
