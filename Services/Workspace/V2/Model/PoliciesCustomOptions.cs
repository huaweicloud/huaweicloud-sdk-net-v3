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
    /// 通用音视频设置项。
    /// </summary>
    public class PoliciesCustomOptions 
    {

        /// <summary>
        /// 自定义配置规则。
        /// </summary>
        [JsonProperty("custom_configuration1_rule", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomConfiguration1Rule { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoliciesCustomOptions {\n");
            sb.Append("  customConfiguration1Rule: ").Append(CustomConfiguration1Rule).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoliciesCustomOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoliciesCustomOptions input)
        {
            if (input == null) return false;
            if (this.CustomConfiguration1Rule != input.CustomConfiguration1Rule || (this.CustomConfiguration1Rule != null && !this.CustomConfiguration1Rule.Equals(input.CustomConfiguration1Rule))) return false;

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
                if (this.CustomConfiguration1Rule != null) hashCode = hashCode * 59 + this.CustomConfiguration1Rule.GetHashCode();
                return hashCode;
            }
        }
    }
}
