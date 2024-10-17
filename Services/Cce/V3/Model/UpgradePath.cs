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
    /// 升级路径
    /// </summary>
    public class UpgradePath 
    {

        /// <summary>
        /// 集群版本，v1.19及以下集群形如v1.19.16-r20，v1.21及以上形如v1.21,v1.23，详细请参考CCE集群版本号说明。
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// CCE集群平台版本号，表示集群版本(version)下的内部版本。用于跟踪某一集群版本内的迭代，集群版本内唯一，跨集群版本重新计数。   platformVersion格式为：cce.X.Y   - X: 表示内部特性版本。集群版本中特性或者补丁修复，或者OS支持等变更场景。其值从1开始单调递增。  - Y: 表示内部特性版本的补丁版本。仅用于特性版本上线后的软件包更新，不涉及其他修改。其值从0开始单调递增。
        /// </summary>
        [JsonProperty("platformVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string PlatformVersion { get; set; }

        /// <summary>
        /// 可升级的目标版本集合
        /// </summary>
        [JsonProperty("targetVersions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TargetVersions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpgradePath {\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  platformVersion: ").Append(PlatformVersion).Append("\n");
            sb.Append("  targetVersions: ").Append(TargetVersions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpgradePath);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpgradePath input)
        {
            if (input == null) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.PlatformVersion != input.PlatformVersion || (this.PlatformVersion != null && !this.PlatformVersion.Equals(input.PlatformVersion))) return false;
            if (this.TargetVersions != input.TargetVersions || (this.TargetVersions != null && input.TargetVersions != null && !this.TargetVersions.SequenceEqual(input.TargetVersions))) return false;

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
                if (this.PlatformVersion != null) hashCode = hashCode * 59 + this.PlatformVersion.GetHashCode();
                if (this.TargetVersions != null) hashCode = hashCode * 59 + this.TargetVersions.GetHashCode();
                return hashCode;
            }
        }
    }
}
