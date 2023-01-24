using UnityEngine;
using ILogger = Northgard.Core.Abstraction.Logger.ILogger;

namespace Northgard.Infrastructure.Logger
{
    internal class UnityLogger : ILogger
    {
        public void LogMessage(string msg)
        {
            Debug.Log(msg);
        }

        public void LogWarning(string msg)
        {
            Debug.LogWarning(msg);
        }

        public void LogError(string msg)
        {
            Debug.LogError(msg);
        }
    }
}