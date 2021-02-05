using System.ServiceProcess;

namespace ConvertToolService
{
    public partial class Service : ServiceBase
    {
        public Service()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Microsoft.Owin.Hosting.WebApp.Start<Startup>("http://localhost:55555");
        }

        protected override void OnStop()
        {
        }
    }
}
