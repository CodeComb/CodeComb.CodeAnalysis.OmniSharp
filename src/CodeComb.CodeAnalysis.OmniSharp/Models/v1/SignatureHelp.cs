using System.Collections.Generic;

namespace CodeComb.CodeAnalysis.OmniSharp.Models
{
    public class SignatureHelp
    {
        public IEnumerable<SignatureHelpItem> Signatures { get; set; }

        public int ActiveSignature { get; set; }
        
        public int ActiveParameter { get; set; }
    }
}