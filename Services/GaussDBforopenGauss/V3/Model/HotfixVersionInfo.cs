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
    /// 热补丁信息。
    /// </summary>
    public class HotfixVersionInfo 
    {

        /// <summary>
        /// 热补丁版本。
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// 热补丁升级完成时间列表。  热补丁升级完成时间，格式为“yyyy-mm-dd hh:mm:ss timezone”。  其中timezone是指时区。
        /// </summary>
        [JsonProperty("upgrade_finished_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpgradeFinishedTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HotfixVersionInfo {\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  upgradeFinishedTime: ").Append(UpgradeFinishedTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HotfixVersionInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HotfixVersionInfo input)
        {
            if (input == null) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.UpgradeFinishedTime != input.UpgradeFinishedTime || (this.UpgradeFinishedTime != null && !this.UpgradeFinishedTime.Equals(input.UpgradeFinishedTime))) return false;

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
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.UpgradeFinishedTime != null) hashCode = hashCode * 59 + this.UpgradeFinishedTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
