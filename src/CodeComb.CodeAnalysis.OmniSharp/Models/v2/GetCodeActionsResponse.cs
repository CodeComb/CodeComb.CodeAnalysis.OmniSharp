using System.Collections.Generic;

namespace CodeComb.CodeAnalysis.OmniSharp.Models.V2
{
    public class GetCodeActionsResponse
    {
        public IEnumerable<OmniSharpCodeAction> CodeActions { get; set; }
    }
}
