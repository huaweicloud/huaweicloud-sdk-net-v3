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
    /// 
    /// </summary>
    public class UpgradePgMajorVersion 
    {

        /// <summary>
        /// 目标版本。 高于实例当前的大版本，如当前为12，目标版本需要是13或14。
        /// </summary>
        [JsonProperty("target_version", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetVersion { get; set; }

        /// <summary>
        /// 是否将实例内网IP切换到大版本实例  true：升级后切换当前实例的内网IP到大版本实例 false：升级后当前实例的内网IP不变，大版本实例使用新的内网IP
        /// </summary>
        [JsonProperty("is_change_private_ip", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsChangePrivateIp { get; set; }

        /// <summary>
        /// 统计信息收集方式。is_change_private_ip为true时必选  before_change_private_ip：将实例内网IP切换到大版本实例前收集  after_change_private_ip：将实例内网IP切换到大版本实例后收集
        /// </summary>
        [JsonProperty("statistics_collection_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string StatisticsCollectionMode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpgradePgMajorVersion {\n");
            sb.Append("  targetVersion: ").Append(TargetVersion).Append("\n");
            sb.Append("  isChangePrivateIp: ").Append(IsChangePrivateIp).Append("\n");
            sb.Append("  statisticsCollectionMode: ").Append(StatisticsCollectionMode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpgradePgMajorVersion);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpgradePgMajorVersion input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TargetVersion == input.TargetVersion ||
                    (this.TargetVersion != null &&
                    this.TargetVersion.Equals(input.TargetVersion))
                ) && 
                (
                    this.IsChangePrivateIp == input.IsChangePrivateIp ||
                    (this.IsChangePrivateIp != null &&
                    this.IsChangePrivateIp.Equals(input.IsChangePrivateIp))
                ) && 
                (
                    this.StatisticsCollectionMode == input.StatisticsCollectionMode ||
                    (this.StatisticsCollectionMode != null &&
                    this.StatisticsCollectionMode.Equals(input.StatisticsCollectionMode))
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
                if (this.TargetVersion != null)
                    hashCode = hashCode * 59 + this.TargetVersion.GetHashCode();
                if (this.IsChangePrivateIp != null)
                    hashCode = hashCode * 59 + this.IsChangePrivateIp.GetHashCode();
                if (this.StatisticsCollectionMode != null)
                    hashCode = hashCode * 59 + this.StatisticsCollectionMode.GetHashCode();
                return hashCode;
            }
        }
    }
}
