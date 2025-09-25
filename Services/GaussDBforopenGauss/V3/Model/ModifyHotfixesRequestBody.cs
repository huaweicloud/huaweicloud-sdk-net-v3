using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ModifyHotfixesRequestBody 
    {

        /// <summary>
        /// **参数解释**: 热补丁属性信息。 **约束限制**: 不涉及。
        /// </summary>
        [JsonProperty("hotfixes", NullValueHandling = NullValueHandling.Ignore)]
        public Object Hotfixes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyHotfixesRequestBody {\n");
            sb.Append("  hotfixes: ").Append(Hotfixes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModifyHotfixesRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModifyHotfixesRequestBody input)
        {
            if (input == null) return false;
            if (this.Hotfixes != input.Hotfixes || (this.Hotfixes != null && !this.Hotfixes.Equals(input.Hotfixes))) return false;

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
                if (this.Hotfixes != null) hashCode = hashCode * 59 + this.Hotfixes.GetHashCode();
                return hashCode;
            }
        }
    }
}
