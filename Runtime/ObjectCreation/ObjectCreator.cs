using JetBrains.Annotations;
using Northgard.Core.Infrastructure.ObjectCreation;
using UnityEngine;
using Zenject;
using Object = UnityEngine.Object;

namespace Northgard.Infrastructure.ObjectCreation
{
    [UsedImplicitly]
    internal class ObjectCreator : MonoBehaviour, IObjectCreator
    {
        [Inject] private DiContainer _container;

        private void Start()
        {
            ObjectCreatorAccessor.ObjectCreator = this;
        }

        public new T Instantiate<T>(T original) where T : Object
        {
            return _container.InstantiatePrefabForComponent<T>(original);
        }
    }
}