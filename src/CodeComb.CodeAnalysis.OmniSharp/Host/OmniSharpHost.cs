using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CodeComb.CodeAnalysis.OmniSharp.Host
{
    public class OmniSharpHost : IDisposable
    {
        public uint Port { get; set; } = 2000;
        public string Source { get; set; } = "./";
        private Process OmniSharp { get; set; } = new Process();

        public void Dispose()
        {
            OmniSharp.Dispose();
        }

        public void Start()
        {
            OmniSharp.StartInfo = new ProcessStartInfo
            {
                FileName = "OmniSharp",
                Arguments = $"-p {Port} -s {Source}",
                UseShellExecute = false,
#if NET451
                WindowStyle = ProcessWindowStyle.Hidden,
#endif 
                CreateNoWindow = true
            };
            OmniSharp.Start();
        }

        public void Stop()
        {
            OmniSharp.Kill();
        }
    }
}
