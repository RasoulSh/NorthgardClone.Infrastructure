using JetBrains.Annotations;
using Northgard.Core.Data;
using Northgard.Enterprise.DataSets;

namespace Northgard.Infrastructure.Persistence.DataTables
{
    [UsedImplicitly]
    internal class WorldDataTable : DataTable<WorldDataset>
    {
        protected override string StorageName => "WorldsMapsData";
    }
}