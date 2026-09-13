using SUTH.HealthCheckup.Domain.Common;

namespace SUTH.HealthCheckup.WinFormsUI.Helpers;

/// <summary>
/// Converts SmartEnum instances into a list compatible with DevExpress LookUpEdit data binding.
/// Property names match the existing ReferenceValueViewModel so DisplayMember/ValueMember remain unchanged.
/// </summary>
public static class SmartEnumBindingHelper
{
    public static List<LookupItem> ToDataSource<T>(
        IReadOnlyList<T> items, string cultureCode = null) where T : SmartEnum<T>
    {
        return items.Select(e => new LookupItem
        {
            ValueCode = e.Value,
            Descriptions = e.GetDisplayName(cultureCode)
        }).ToList();
    }
}

public class LookupItem
{
    public string ValueCode { get; set; }
    public string Descriptions { get; set; }
}
