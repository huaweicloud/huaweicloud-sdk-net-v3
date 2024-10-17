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
    /// Response Object
    /// </summary>
    public class ListClusterUpgradeFeatureGatesResponse : SdkResponse
    {

        /// <summary>
        /// API版本
        /// </summary>
        [JsonProperty("apiVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string ApiVersion { get; set; }

        /// <summary>
        /// 资源类型
        /// </summary>
        [JsonProperty("kind", NullValueHandling = NullValueHandling.Ignore)]
        public string Kind { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Metadata Metadata { get; set; }

        /// <summary>
        /// 特性开关信息,格式为key/value键值对。 - Key: 目前有下列值：DisplayPreCheckDetail(展示所有集群升级前检查项详情),EvsSnapshot(使用EVS快照备份集群), LabelForSkippedNode(支持为集群升级过程中跳过的节点打标签), UpgradeStrategy(集群升级策略) - Value: Support 支持,Disable 关闭,Default 使用CCE服务默认规则判断
        /// </summary>
        [JsonProperty("upgradeFeatureGates", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> UpgradeFeatureGates { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListClusterUpgradeFeatureGatesResponse {\n");
            sb.Append("  apiVersion: ").Append(ApiVersion).Append("\n");
            sb.Append("  kind: ").Append(Kind).Append("\n");
            sb.Append("  metadata: ").Append(Metadata).Append("\n");
            sb.Append("  upgradeFeatureGates: ").Append(UpgradeFeatureGates).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListClusterUpgradeFeatureGatesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListClusterUpgradeFeatureGatesResponse input)
        {
            if (input == null) return false;
            if (this.ApiVersion != input.ApiVersion || (this.ApiVersion != null && !this.ApiVersion.Equals(input.ApiVersion))) return false;
            if (this.Kind != input.Kind || (this.Kind != null && !this.Kind.Equals(input.Kind))) return false;
            if (this.Metadata != input.Metadata || (this.Metadata != null && !this.Metadata.Equals(input.Metadata))) return false;
            if (this.UpgradeFeatureGates != input.UpgradeFeatureGates || (this.UpgradeFeatureGates != null && input.UpgradeFeatureGates != null && !this.UpgradeFeatureGates.SequenceEqual(input.UpgradeFeatureGates))) return false;

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
                if (this.ApiVersion != null) hashCode = hashCode * 59 + this.ApiVersion.GetHashCode();
                if (this.Kind != null) hashCode = hashCode * 59 + this.Kind.GetHashCode();
                if (this.Metadata != null) hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.UpgradeFeatureGates != null) hashCode = hashCode * 59 + this.UpgradeFeatureGates.GetHashCode();
                return hashCode;
            }
        }
    }
}
