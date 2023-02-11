using Northgard.Core.Data;
using Northgard.Core.Infrastructure.Localization;
using Northgard.Core.Infrastructure.ObjectCreation;
using Northgard.Enterprise.DataSets;
using Northgard.Infrastructure.Localization;
using Northgard.Infrastructure.Logger;
using Northgard.Infrastructure.ObjectCreation;
using Northgard.Infrastructure.Persistence.DataSavers;
using Northgard.Infrastructure.Persistence.DataTables;
using UnityEngine;
using Zenject;
using ILogger = Northgard.Core.Infrastructure.Logger.ILogger;

namespace Northgard.Infrastructure
{
    [RequireComponent(typeof(ObjectCreator))]
    public class InfrastructureInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<ILocalization>().To<TempLocalization>().FromNew().AsSingle();
            Container.Bind<ILogger>().To<UnityLogger>().FromNew().AsSingle();
            var objectCreator = GetComponent<ObjectCreator>();
            Container.Bind<IObjectCreator>().To<ObjectCreator>().FromInstance(objectCreator).AsSingle();
            Container.Bind<IDataSaver<WorldDataset>>().To<EncryptedXmlDataSaver<WorldDataset>>().FromNew().AsSingle();
            Container.Bind<IDataTable<WorldDataset>>().To<WorldDataTable>().FromNew().AsSingle();
        }
    }
}