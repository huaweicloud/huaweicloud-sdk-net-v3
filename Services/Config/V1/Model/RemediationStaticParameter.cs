using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Config.V1.Model
{
    /// <summary>
    /// 合规规则修正执行的静态参数。
    /// </summary>
    public class RemediationStaticParameter 
    {

        /// <summary>
        /// 参数名称。
        /// </summary>
        [JsonProperty("var_key", NullValueHandling = NullValueHandling.Ignore)]
        public string VarKey { get; set; }

        /// <summary>
        /// 参数的值。
        /// </summary>
        [JsonProperty("var_value", NullValueHandling = NullValueHandling.Ignore)]
        public Object VarValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RemediationStaticParameter {\n");
            sb.Append("  varKey: ").Append(VarKey).Append("\n");
            sb.Append("  varValue: ").Append(VarValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RemediationStaticParameter);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RemediationStaticParameter input)
        {
            if (input == null) return false;
            if (this.VarKey != input.VarKey || (this.VarKey != null && !this.VarKey.Equals(input.VarKey))) return false;
            if (this.VarValue != input.VarValue || (this.VarValue != null && !this.VarValue.Equals(input.VarValue))) return false;

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
                if (this.VarKey != null) hashCode = hashCode * 59 + this.VarKey.GetHashCode();
                if (this.VarValue != null) hashCode = hashCode * 59 + this.VarValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
