using System.Collections.Generic;


namespace CodeComb.CodeAnalysis.OmniSharp.Models
{
    // [OmniSharpEndpoint(OmnisharpEndpoints.PackageSource, typeof(PackageSourceRequest), typeof(PackageSourceResponse))]
    public class PackageSourceRequest : Request
    {
        /// <summary>
        /// The path to the project file
        /// </summary>
        public string ProjectPath { get; set; }
    }
}
