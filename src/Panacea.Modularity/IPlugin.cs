using System;
using System.Threading.Tasks;

namespace Panacea.Modularity
{
    public interface IPlugin:IDisposable
    {
        Task BeginInit();

        Task EndInit();

        Task Shutdown();
    }
}
