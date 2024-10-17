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
    /// 升级配置相关信息
    /// </summary>
    public class UpgradeInfoSpec 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("lastUpgradeInfo", NullValueHandling = NullValueHandling.Ignore)]
        public UpgradeInfoStatus LastUpgradeInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("versionInfo", NullValueHandling = NullValueHandling.Ignore)]
        public UpgradeVersionInfo VersionInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("upgradeFeatureGates", NullValueHandling = NullValueHandling.Ignore)]
        public UpgradeFeatureGates UpgradeFeatureGates { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpgradeInfoSpec {\n");
            sb.Append("  lastUpgradeInfo: ").Append(LastUpgradeInfo).Append("\n");
            sb.Append("  versionInfo: ").Append(VersionInfo).Append("\n");
            sb.Append("  upgradeFeatureGates: ").Append(UpgradeFeatureGates).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpgradeInfoSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpgradeInfoSpec input)
        {
            if (input == null) return false;
            if (this.LastUpgradeInfo != input.LastUpgradeInfo || (this.LastUpgradeInfo != null && !this.LastUpgradeInfo.Equals(input.LastUpgradeInfo))) return false;
            if (this.VersionInfo != input.VersionInfo || (this.VersionInfo != null && !this.VersionInfo.Equals(input.VersionInfo))) return false;
            if (this.UpgradeFeatureGates != input.UpgradeFeatureGates || (this.UpgradeFeatureGates != null && !this.UpgradeFeatureGates.Equals(input.UpgradeFeatureGates))) return false;

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
                if (this.LastUpgradeInfo != null) hashCode = hashCode * 59 + this.LastUpgradeInfo.GetHashCode();
                if (this.VersionInfo != null) hashCode = hashCode * 59 + this.VersionInfo.GetHashCode();
                if (this.UpgradeFeatureGates != null) hashCode = hashCode * 59 + this.UpgradeFeatureGates.GetHashCode();
                return hashCode;
            }
        }
    }
}
