using System.Runtime.Versioning;
using System.ServiceProcess;

namespace PharmacyHome
{
    [SupportedOSPlatform("windows")]
    public class Service : ServiceBase
    {
        public Service() => ServiceName = "PharmacyHome";

        protected override void OnStart(string[] args) => Program.Start(args);
        protected override void OnStop() => Program.Stop();
    }
}
