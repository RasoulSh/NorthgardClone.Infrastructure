using System.Collections.Generic;
using System.IO;
using JetBrains.Annotations;
using Northgard.Core.Data;
using Northgard.Core.Encryption;
using Northgard.Core.EntityBase;
using UnityEngine;

namespace Northgard.Infrastructure.Persistence.DataSavers
{
    [UsedImplicitly]
    internal class EncryptedXmlDataSaver<T> : IDataSaver<T> where T : GameEntity
    {
        private const string FileExtension = ".gamedata"; 
        private static string RootPath
        {
            get
            {
                var rootPath = Application.dataPath;
#if UNITY_EDITOR
                var directory = new DirectoryInfo(rootPath);
                return directory.Parent.FullName;
#endif
                return rootPath;
            }
        }

        private string GetFilePath(string storageName)
        {
            return RootPath + "/" + storageName + FileExtension;
        }
        
        public void Save(List<T> data, string storageName)
        {
            var filePath = GetFilePath(storageName);
            EncryptedXmlSerializer.Save<List<T>>(filePath, data);
        }

        public List<T> Load(string storageName)
        {
            var filePath = GetFilePath(storageName);
            return EncryptedXmlSerializer.Load<List<T>>(filePath);
        }

        public void Delete(string storageName)
        {
            var filePath = GetFilePath(storageName);
            File.Delete(filePath);
        }
    }
}