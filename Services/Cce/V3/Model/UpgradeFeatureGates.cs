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
    /// **参数解释：** 集群升级特性开关 **约束限制：** 不涉及 **取值范围：** 不涉及 **默认取值：** 不涉及 
    /// </summary>
    public class UpgradeFeatureGates 
    {

        /// <summary>
        /// **参数解释：** 集群升级Console界面是否支持V4版本，该字段一般由CCE Console使用。 **约束限制：** 不涉及 **取值范围：** - true：支持V4版本 - false：不支持V4版本  **默认取值：** 不涉及 
        /// </summary>
        [JsonProperty("supportUpgradePageV4", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SupportUpgradePageV4 { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpgradeFeatureGates {\n");
            sb.Append("  supportUpgradePageV4: ").Append(SupportUpgradePageV4).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpgradeFeatureGates);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpgradeFeatureGates input)
        {
            if (input == null) return false;
            if (this.SupportUpgradePageV4 != input.SupportUpgradePageV4 || (this.SupportUpgradePageV4 != null && !this.SupportUpgradePageV4.Equals(input.SupportUpgradePageV4))) return false;

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
                if (this.SupportUpgradePageV4 != null) hashCode = hashCode * 59 + this.SupportUpgradePageV4.GetHashCode();
                return hashCode;
            }
        }
    }
}
