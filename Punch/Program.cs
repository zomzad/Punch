using System.ServiceProcess;

namespace Punch
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new Punch()
            }; 
            ServiceBase.Run(ServicesToRun);
        }
    }
}
