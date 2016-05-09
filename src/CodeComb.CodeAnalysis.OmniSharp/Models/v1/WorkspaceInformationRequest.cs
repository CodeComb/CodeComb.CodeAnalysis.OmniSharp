

namespace CodeComb.CodeAnalysis.OmniSharp.Models.v1
{
    // [OmniSharpEndpoint(OmnisharpEndpoints.WorkspaceInformation, typeof(WorkspaceInformationRequest), typeof(WorkspaceInformationResponse))]
    public class WorkspaceInformationRequest : Request
    {
        public bool ExcludeSourceFiles { get; set; }
    }
}
