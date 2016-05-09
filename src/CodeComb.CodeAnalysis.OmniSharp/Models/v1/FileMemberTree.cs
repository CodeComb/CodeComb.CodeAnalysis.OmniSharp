using System;
using System.Collections.Generic;

namespace CodeComb.CodeAnalysis.OmniSharp.Models
{
    public class FileMemberTree
    {
        public IEnumerable<FileMemberElement> TopLevelTypeDefinitions { get; set; }
    }
}
