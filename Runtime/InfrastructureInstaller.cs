using Northgard.Core.Abstraction.Logger;
using Northgard.Infrastructure.Logger;
using Zenject;

namespace Northgard.Infrastructure
{
    public class InfrastructureInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<ILogger>().To<UnityLogger>().FromNew().AsSingle();
        }
    }
}