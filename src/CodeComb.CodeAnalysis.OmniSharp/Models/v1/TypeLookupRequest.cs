

﻿namespace CodeComb.CodeAnalysis.OmniSharp.Models
{
    // [OmniSharpEndpoint(OmnisharpEndpoints.TypeLookup, typeof(TypeLookupRequest), typeof(TypeLookupResponse))]
    public class TypeLookupRequest : Request
    {
        public bool IncludeDocumentation { get; set; }
    }
}
