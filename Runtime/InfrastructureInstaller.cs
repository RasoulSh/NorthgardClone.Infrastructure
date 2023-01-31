using Northgard.Core.Abstraction.Localization;
using Northgard.Core.Abstraction.Logger;
using Northgard.Infrastructure.Localization;
using Northgard.Infrastructure.Logger;
using Zenject;

namespace Northgard.Infrastructure
{
    public class InfrastructureInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<ILocalization>().To<TempLocalization>().FromNew().AsSingle();
            Container.Bind<ILogger>().To<UnityLogger>().FromNew().AsSingle();
        }
    }
}