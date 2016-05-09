

﻿namespace CodeComb.CodeAnalysis.OmniSharp.Models
{
    // [OmniSharpEndpoint(OmnisharpEndpoints.FindSymbols, typeof(FindSymbolsRequest), typeof(QuickFixResponse))]
    public class FindSymbolsRequest : Request
    {
        public string Language { get; set; }
        public string Filter { get; set; }
    }
}
