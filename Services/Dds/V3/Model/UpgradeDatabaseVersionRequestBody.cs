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
        /// 升级模式。  取值为“minimized_interrupt_time”为中断时间最短优先模式：升级过程对业务影响相对较小的升级方式  取值为“minimized_upgrade_time”为升级时长最短优先模式：升级过程时长相对较快的升级方式。  默认取值为“minimized_interrupt_time”。
        /// </summary>
        [JsonProperty("upgrade_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string UpgradeMode { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpgradeDatabaseVersionRequestBody {\n");
            sb.Append("  upgradeMode: ").Append(UpgradeMode).Append("\n");
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
            if (input == null)
                return false;

            return 
                (
                    this.UpgradeMode == input.UpgradeMode ||
                    (this.UpgradeMode != null &&
                    this.UpgradeMode.Equals(input.UpgradeMode))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.UpgradeMode != null)
                    hashCode = hashCode * 59 + this.UpgradeMode.GetHashCode();
                return hashCode;
            }
        }
    }
}
