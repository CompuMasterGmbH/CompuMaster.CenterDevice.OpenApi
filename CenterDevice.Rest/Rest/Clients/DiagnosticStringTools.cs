using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterDevice.Rest.Clients
{
    internal static class DiagnosticStringTools
    {
        /// <summary>
        /// Indent a string
        /// </summary>
        public static string Indent(this string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return string.Empty;
            else
            {
                string result = "    " + value.Replace("\n", "\n    ");
                if (result.EndsWith("\n    "))
                    result = result.Substring(0, result.Length - ("\n    ".Length - 1));
                return result;
            }
        }

        /// <summary>
        /// ToString for bool? with alt text
        /// </summary>
        public static string ToString(this bool? value, string textIfNull)
        {
            if (value.HasValue == false)
                return textIfNull;
            else
            {
                return value.ToString();
            }
        }
    }
}