using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CheckTaskSpec 
    {

        /// <summary>
        /// **参数解释：** 插件升级目标版本 **取值范围：** 不涉及 
        /// </summary>
        [JsonProperty("addonTargetVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string AddonTargetVersion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckTaskSpec {\n");
            sb.Append("  addonTargetVersion: ").Append(AddonTargetVersion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CheckTaskSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CheckTaskSpec input)
        {
            if (input == null) return false;
            if (this.AddonTargetVersion != input.AddonTargetVersion || (this.AddonTargetVersion != null && !this.AddonTargetVersion.Equals(input.AddonTargetVersion))) return false;

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
                if (this.AddonTargetVersion != null) hashCode = hashCode * 59 + this.AddonTargetVersion.GetHashCode();
                return hashCode;
            }
        }
    }
}
