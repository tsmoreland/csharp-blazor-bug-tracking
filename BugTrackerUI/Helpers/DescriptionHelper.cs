using System;
using System.ComponentModel;
using System.Reflection;

namespace BugTrackerUI.Helpers
{
    public static class DescriptionHelper
    {
        /// <summary>
        /// returns <see cref="DescriptionAttribute.Description"/> for <paramref name="value"/> if defined; 
        /// otherwise, <see cref="Enum.ToString()"/> for <paramref name="value"/> if it is non-null 
        /// and finally <see cref="String.Empty"/> if <paramref name="value"/> is null
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotSupportedException">thrown by <see cref="Type.GetField(string)"/></exception>
        public static string GetDescriptionAttributeOrToString(Enum value)
        {
            if (value == null)
                return string.Empty;

            var enumType = value.GetType();
            var enumName = Enum.GetName(enumType, value);

            return enumName == null
                ? value.ToString()
                : enumType.GetField(enumName)?.GetCustomAttribute<DescriptionAttribute>()?.Description ?? value.ToString();
        }
    }
}
