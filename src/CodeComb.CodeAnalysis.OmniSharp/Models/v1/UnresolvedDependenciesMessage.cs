using System.Collections.Generic;

namespace CodeComb.CodeAnalysis.OmniSharp.Models
{
    public class UnresolvedDependenciesMessage
    {
        public string FileName { get; set; }

        public IEnumerable<PackageDependency> UnresolvedDependencies { get; set; }
    }
}