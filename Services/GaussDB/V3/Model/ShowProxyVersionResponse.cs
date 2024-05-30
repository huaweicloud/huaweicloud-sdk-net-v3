using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowProxyVersionResponse : SdkResponse
    {

        /// <summary>
        /// 当前代理版本
        /// </summary>
        [JsonProperty("current_version", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentVersion { get; set; }

        /// <summary>
        /// 最新代理版本
        /// </summary>
        [JsonProperty("latest_version", NullValueHandling = NullValueHandling.Ignore)]
        public string LatestVersion { get; set; }

        /// <summary>
        /// 是否能升级
        /// </summary>
        [JsonProperty("can_upgrade", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanUpgrade { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowProxyVersionResponse {\n");
            sb.Append("  currentVersion: ").Append(CurrentVersion).Append("\n");
            sb.Append("  latestVersion: ").Append(LatestVersion).Append("\n");
            sb.Append("  canUpgrade: ").Append(CanUpgrade).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowProxyVersionResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowProxyVersionResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CurrentVersion == input.CurrentVersion ||
                    (this.CurrentVersion != null &&
                    this.CurrentVersion.Equals(input.CurrentVersion))
                ) && 
                (
                    this.LatestVersion == input.LatestVersion ||
                    (this.LatestVersion != null &&
                    this.LatestVersion.Equals(input.LatestVersion))
                ) && 
                (
                    this.CanUpgrade == input.CanUpgrade ||
                    (this.CanUpgrade != null &&
                    this.CanUpgrade.Equals(input.CanUpgrade))
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
                if (this.CurrentVersion != null)
                    hashCode = hashCode * 59 + this.CurrentVersion.GetHashCode();
                if (this.LatestVersion != null)
                    hashCode = hashCode * 59 + this.LatestVersion.GetHashCode();
                if (this.CanUpgrade != null)
                    hashCode = hashCode * 59 + this.CanUpgrade.GetHashCode();
                return hashCode;
            }
        }
    }
}
