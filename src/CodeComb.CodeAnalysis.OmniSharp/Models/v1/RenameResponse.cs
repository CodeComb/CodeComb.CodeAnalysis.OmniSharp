using System.Collections.Generic;

namespace CodeComb.CodeAnalysis.OmniSharp.Models
{
    public class RenameResponse
    {
        public RenameResponse()
        {
            Changes = new List<ModifiedFileResponse>();
        }

        public IEnumerable<ModifiedFileResponse> Changes { get; set; }

        public string ErrorMessage { get; set; }
    }
}