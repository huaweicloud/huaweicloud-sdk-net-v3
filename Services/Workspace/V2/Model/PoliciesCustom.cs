using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 自定义策略。
    /// </summary>
    public class PoliciesCustom 
    {

        /// <summary>
        /// 自定义配置启用。
        /// </summary>
        [JsonProperty("custom_configuration1_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CustomConfiguration1Enable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("options", NullValueHandling = NullValueHandling.Ignore)]
        public PoliciesCustomOptions Options { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoliciesCustom {\n");
            sb.Append("  customConfiguration1Enable: ").Append(CustomConfiguration1Enable).Append("\n");
            sb.Append("  options: ").Append(Options).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoliciesCustom);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoliciesCustom input)
        {
            if (input == null) return false;
            if (this.CustomConfiguration1Enable != input.CustomConfiguration1Enable || (this.CustomConfiguration1Enable != null && !this.CustomConfiguration1Enable.Equals(input.CustomConfiguration1Enable))) return false;
            if (this.Options != input.Options || (this.Options != null && !this.Options.Equals(input.Options))) return false;

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
                if (this.CustomConfiguration1Enable != null) hashCode = hashCode * 59 + this.CustomConfiguration1Enable.GetHashCode();
                if (this.Options != null) hashCode = hashCode * 59 + this.Options.GetHashCode();
                return hashCode;
            }
        }
    }
}
