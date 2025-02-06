using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowAutoUpgradePolicyResponse : SdkResponse
    {

        /// <summary>
        /// 自动小版本升级开关选项 true：打开自动小版本升级 false：关闭自动小版本升级
        /// </summary>
        [JsonProperty("switch_option", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SwitchOption { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAutoUpgradePolicyResponse {\n");
            sb.Append("  switchOption: ").Append(SwitchOption).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAutoUpgradePolicyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAutoUpgradePolicyResponse input)
        {
            if (input == null) return false;
            if (this.SwitchOption != input.SwitchOption || (this.SwitchOption != null && !this.SwitchOption.Equals(input.SwitchOption))) return false;

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
                if (this.SwitchOption != null) hashCode = hashCode * 59 + this.SwitchOption.GetHashCode();
                return hashCode;
            }
        }
    }
}
