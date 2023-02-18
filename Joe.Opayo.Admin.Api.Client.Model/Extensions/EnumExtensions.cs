using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Joe.Opayo.Admin.Api.Client.Model.Extensions
{
    public static class EnumExtensions
    {
        public static string GetDisplayName(this Enum? enumValue)
        {
            if (enumValue == null)
                return string.Empty;

            return enumValue.GetType().GetMember(enumValue.ToString()).First().GetCustomAttribute<DisplayAttribute>()?.GetName() ?? string.Empty;
        }
    }
}
