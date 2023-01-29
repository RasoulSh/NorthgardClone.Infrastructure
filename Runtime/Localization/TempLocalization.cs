using Northgard.Core.Abstraction.Localization;

namespace Northgard.Infrastructure.Localization
{
    public class TempLocalization : ILocalization
    {
        public string GetText(string localizationKey)
        {
            return localizationKey;
        }
    }
}