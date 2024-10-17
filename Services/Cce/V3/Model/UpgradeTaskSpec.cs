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
    /// 升级任务属性
    /// </summary>
    public class UpgradeTaskSpec 
    {

        /// <summary>
        /// 升级前集群版本
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// 升级的目标集群版本
        /// </summary>
        [JsonProperty("targetVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetVersion { get; set; }

        /// <summary>
        /// 升级任务附属信息
        /// </summary>
        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public Object Items { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpgradeTaskSpec {\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  targetVersion: ").Append(TargetVersion).Append("\n");
            sb.Append("  items: ").Append(Items).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpgradeTaskSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpgradeTaskSpec input)
        {
            if (input == null) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.TargetVersion != input.TargetVersion || (this.TargetVersion != null && !this.TargetVersion.Equals(input.TargetVersion))) return false;
            if (this.Items != input.Items || (this.Items != null && !this.Items.Equals(input.Items))) return false;

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
                if (this.TargetVersion != null) hashCode = hashCode * 59 + this.TargetVersion.GetHashCode();
                if (this.Items != null) hashCode = hashCode * 59 + this.Items.GetHashCode();
                return hashCode;
            }
        }
    }
}
