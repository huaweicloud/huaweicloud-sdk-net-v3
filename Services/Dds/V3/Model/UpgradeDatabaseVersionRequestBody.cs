using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpgradeDatabaseVersionRequestBody 
    {

        /// <summary>
        /// **参数解释：** 升级模式。 **约束限制：** 不涉及。 **取值范围：** - minimized_interrupt_time：表示中断时间最短优先模式：升级过程对业务影响相对较小的升级方式。 - minimized_upgrade_time：表示升级时长最短优先模式：升级过程时长相对较快的升级方式。 **默认取值：** minimized_interrupt_time。
        /// </summary>
        [JsonProperty("upgrade_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string UpgradeMode { get; set; }

        /// <summary>
        /// **参数解释：** 实例是否在可维护时间窗内自动升级。 **约束限制：** 不涉及。 **取值范围：** - true：表示延迟升级，实例将在可维护时间窗内自动升级。 - false：表示立即升级。 **默认取值：** false。
        /// </summary>
        [JsonProperty("is_delayed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDelayed { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpgradeDatabaseVersionRequestBody {\n");
            sb.Append("  upgradeMode: ").Append(UpgradeMode).Append("\n");
            sb.Append("  isDelayed: ").Append(IsDelayed).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpgradeDatabaseVersionRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpgradeDatabaseVersionRequestBody input)
        {
            if (input == null) return false;
            if (this.UpgradeMode != input.UpgradeMode || (this.UpgradeMode != null && !this.UpgradeMode.Equals(input.UpgradeMode))) return false;
            if (this.IsDelayed != input.IsDelayed || (this.IsDelayed != null && !this.IsDelayed.Equals(input.IsDelayed))) return false;

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
                if (this.UpgradeMode != null) hashCode = hashCode * 59 + this.UpgradeMode.GetHashCode();
                if (this.IsDelayed != null) hashCode = hashCode * 59 + this.IsDelayed.GetHashCode();
                return hashCode;
            }
        }
    }
}
