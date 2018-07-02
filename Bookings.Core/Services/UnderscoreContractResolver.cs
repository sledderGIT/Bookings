using System;
using System.Globalization;
using System.Text;
using Newtonsoft.Json.Serialization;

namespace Bookings.Core
{   
    
    public class UnderscoreContractResolver : DefaultContractResolver
    {
        private static readonly CultureInfo Culture = CultureInfo.InvariantCulture;

        protected override string ResolvePropertyName(string s)
        {
            var sb = new StringBuilder(s.Length);
    
            bool isNextUpper = false, isPrevLower = false;
    
            for (var i = 0; i < s.Length; i++)
            {
                var c = s[i];
    
                sb.Append(char.ToLower(c, Culture));
    
                isNextUpper = i + 1 < s.Length && char.IsUpper(s[i + 1]);
    
                if (isNextUpper && isPrevLower)
                {
                    sb.Append("_");
                }
    
                isPrevLower = char.IsLower(c);
            }
    
            return sb.ToString();
        }
    }
}
