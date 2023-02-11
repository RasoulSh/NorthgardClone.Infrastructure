using JetBrains.Annotations;
using Northgard.Core.Infrastructure.Localization;

namespace Northgard.Infrastructure.Localization
{
    [UsedImplicitly]
    internal class TempLocalization : ILocalization
    {
        public string GetText(string localizationKey)
        {
            return localizationKey;
        }
    }
}