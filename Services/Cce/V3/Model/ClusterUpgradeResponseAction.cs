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
    public class ClusterUpgradeResponseAction 
    {

        /// <summary>
        /// 当前集群版本
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// 目标集群版本，例如\&quot;v1.23\&quot;
        /// </summary>
        [JsonProperty("targetVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetVersion { get; set; }

        /// <summary>
        /// 目标集群的平台版本号，表示集群版本(version)下的内部版本，不支持用户指定。
        /// </summary>
        [JsonProperty("targetPlatformVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetPlatformVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("strategy", NullValueHandling = NullValueHandling.Ignore)]
        public UpgradeStrategy Strategy { get; set; }

        /// <summary>
        /// 升级过程中指定的集群配置
        /// </summary>
        [JsonProperty("config", NullValueHandling = NullValueHandling.Ignore)]
        public Object Config { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClusterUpgradeResponseAction {\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  targetVersion: ").Append(TargetVersion).Append("\n");
            sb.Append("  targetPlatformVersion: ").Append(TargetPlatformVersion).Append("\n");
            sb.Append("  strategy: ").Append(Strategy).Append("\n");
            sb.Append("  config: ").Append(Config).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ClusterUpgradeResponseAction);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ClusterUpgradeResponseAction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.TargetVersion == input.TargetVersion ||
                    (this.TargetVersion != null &&
                    this.TargetVersion.Equals(input.TargetVersion))
                ) && 
                (
                    this.TargetPlatformVersion == input.TargetPlatformVersion ||
                    (this.TargetPlatformVersion != null &&
                    this.TargetPlatformVersion.Equals(input.TargetPlatformVersion))
                ) && 
                (
                    this.Strategy == input.Strategy ||
                    (this.Strategy != null &&
                    this.Strategy.Equals(input.Strategy))
                ) && 
                (
                    this.Config == input.Config ||
                    (this.Config != null &&
                    this.Config.Equals(input.Config))
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
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.TargetVersion != null)
                    hashCode = hashCode * 59 + this.TargetVersion.GetHashCode();
                if (this.TargetPlatformVersion != null)
                    hashCode = hashCode * 59 + this.TargetPlatformVersion.GetHashCode();
                if (this.Strategy != null)
                    hashCode = hashCode * 59 + this.Strategy.GetHashCode();
                if (this.Config != null)
                    hashCode = hashCode * 59 + this.Config.GetHashCode();
                return hashCode;
            }
        }
    }
}
