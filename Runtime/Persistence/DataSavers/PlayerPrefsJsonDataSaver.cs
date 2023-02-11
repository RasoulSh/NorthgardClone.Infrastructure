using System.Collections.Generic;
using JetBrains.Annotations;
using Northgard.Core.Data;
using Northgard.Core.EntityBase;
using UnityEngine;

namespace Northgard.Infrastructure.Persistence.DataSavers
{
    [UsedImplicitly]
    internal class PlayerPrefsJsonDataSaver<T> : IDataSaver<T> where T : GameEntity
    {
        private readonly string _defaultJsonData = JsonUtility.ToJson(new List<T>());
        public void Save(List<T> data, string storageName)
        {
            var dataJson = JsonUtility.ToJson(data);
            PlayerPrefs.SetString(storageName, dataJson);
        }

        public List<T> Load(string storageName)
        {
            var dataJson = PlayerPrefs.GetString(storageName, _defaultJsonData);
            var data = JsonUtility.FromJson<List<T>>(dataJson);
            return data;
        }

        public void Delete(string storageName)
        {
            PlayerPrefs.DeleteKey(storageName);
        }
    }
}