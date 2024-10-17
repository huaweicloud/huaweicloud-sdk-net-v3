using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AppRulesBody 
    {

        /// <summary>
        /// 服务参数。
        /// </summary>
        [JsonProperty("appRules", NullValueHandling = NullValueHandling.Ignore)]
        public List<AppRules> AppRules { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppRulesBody {\n");
            sb.Append("  appRules: ").Append(AppRules).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AppRulesBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AppRulesBody input)
        {
            if (input == null) return false;
            if (this.AppRules != input.AppRules || (this.AppRules != null && input.AppRules != null && !this.AppRules.SequenceEqual(input.AppRules))) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.AppRules != null) hashCode = hashCode * 59 + this.AppRules.GetHashCode();
                return hashCode;
            }
        }
    }
}
