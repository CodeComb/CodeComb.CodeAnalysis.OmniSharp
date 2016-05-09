using System.Collections.Generic;

namespace CodeComb.CodeAnalysis.OmniSharp.Models
{
    public class PackageSearchResponse
    {
        public IEnumerable<PackageSearchItem> Packages { get; set; }
    }
}
