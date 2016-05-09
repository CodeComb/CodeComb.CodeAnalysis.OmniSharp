using Microsoft.CodeAnalysis;


namespace CodeComb.CodeAnalysis.OmniSharp.Models
{
    // [OmniSharpEndpoint(OmnisharpEndpoints.Metadata, typeof(MetadataRequest), typeof(MetadataResponse))]
    public class MetadataRequest : MetadataSource, IRequest
    {
        public int Timeout { get; set; } = 2000;
    }
}
