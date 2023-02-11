using JetBrains.Annotations;
using UnityEngine;
using ILogger = Northgard.Core.Infrastructure.Logger.ILogger;

namespace Northgard.Infrastructure.Logger
{
    [UsedImplicitly]
    internal class UnityLogger : Core.Infrastructure.Logger.ILogger
    {
        public void LogMessage(string msg, object context)
        {
            var unityContext = context as Object;
            if (unityContext == null)
            {
                msg += " context: " + context;
                Debug.Log(msg);
            }
            else
            {
                Debug.Log(msg, unityContext);
            }
        }

        public void LogWarning(string msg, object context)
        {
            var unityContext = context as Object;
            if (unityContext == null)
            {
                msg += " context: " + context;
                Debug.LogWarning(msg);
            }
            else
            {
                Debug.LogWarning(msg, unityContext);
            }
        }

        public void LogError(string msg, object context)
        {
            var unityContext = context as Object;
            if (unityContext == null)
            {
                msg += " context: " + context;
                Debug.LogError(msg);
            }
            else
            {
                Debug.LogError(msg, unityContext);
            }
        }
    }
}