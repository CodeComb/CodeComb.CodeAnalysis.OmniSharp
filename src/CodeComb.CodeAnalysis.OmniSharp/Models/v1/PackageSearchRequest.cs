using System.Collections.Generic;


namespace CodeComb.CodeAnalysis.OmniSharp.Models
{
    // [OmniSharpEndpoint(OmnisharpEndpoints.PackageSearch, typeof(PackageSearchRequest), typeof(PackageSearchResponse))]
    public class PackageSearchRequest : Request
    {
        /// <summary>
        /// The path to the project file
        /// </summary>
        public string ProjectPath { get; set; }

        /// <summary>
        /// The sources to search for the given package
        /// </summary>
        public IEnumerable<string> Sources { get; set; }

        /// <summary>
        /// The filter search critera
        /// </summary>
        public string Search { get; set; }

        /// <summary>
        /// Filter to only the list of packages compatible with these frameworks.
        /// </summary>
        public IEnumerable<string> SupportedFrameworks { get; set; }

        /// <summary>
        /// Include prerelease packages in search
        /// </summary>
        public bool IncludePrerelease { get; set; }

        /// <summary>
        /// Restrict the search to certain package types.
        /// </summary>
        public IEnumerable<string> PackageTypes { get; set; }
    }
}
