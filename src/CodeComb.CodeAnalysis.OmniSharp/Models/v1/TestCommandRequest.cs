

namespace CodeComb.CodeAnalysis.OmniSharp.Models
{
    // [OmniSharpEndpoint(OmnisharpEndpoints.TestCommand, typeof(TestCommandRequest), typeof(GetTestCommandResponse))]
    public class TestCommandRequest : Request
    {
        public TestCommandType Type { get; set; }
    }
}
