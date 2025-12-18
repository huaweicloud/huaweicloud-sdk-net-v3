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
    public class PrecheckSpec 
    {

        /// <summary>
        /// **参数解释：** 集群ID **约束限制：** 不涉及 **取值范围：** 不涉及 
        /// </summary>
        [JsonProperty("clusterID", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterID { get; set; }

        /// <summary>
        /// **参数解释：** 集群版本，请填写当前集群的补丁版本，可登录控制台在总览页面进行查看 **约束限制：** 不涉及 **取值范围：** 不涉及 
        /// </summary>
        [JsonProperty("clusterVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterVersion { get; set; }

        /// <summary>
        /// **参数解释：** 升级目标版本，如果填写大版本，则自动选择最新补丁版本 **约束限制：** 不涉及 **取值范围：** 高于集群当前版本的可用集群版本 
        /// </summary>
        [JsonProperty("targetVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetVersion { get; set; }

        /// <summary>
        /// **参数解释：** 跳过检查的项目列表 **约束限制：** 不涉及 **取值范围：** 不涉及 
        /// </summary>
        [JsonProperty("skippedCheckItemList", NullValueHandling = NullValueHandling.Ignore)]
        public List<SkippedCheckItemList> SkippedCheckItemList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrecheckSpec {\n");
            sb.Append("  clusterID: ").Append(ClusterID).Append("\n");
            sb.Append("  clusterVersion: ").Append(ClusterVersion).Append("\n");
            sb.Append("  targetVersion: ").Append(TargetVersion).Append("\n");
            sb.Append("  skippedCheckItemList: ").Append(SkippedCheckItemList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PrecheckSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PrecheckSpec input)
        {
            if (input == null) return false;
            if (this.ClusterID != input.ClusterID || (this.ClusterID != null && !this.ClusterID.Equals(input.ClusterID))) return false;
            if (this.ClusterVersion != input.ClusterVersion || (this.ClusterVersion != null && !this.ClusterVersion.Equals(input.ClusterVersion))) return false;
            if (this.TargetVersion != input.TargetVersion || (this.TargetVersion != null && !this.TargetVersion.Equals(input.TargetVersion))) return false;
            if (this.SkippedCheckItemList != input.SkippedCheckItemList || (this.SkippedCheckItemList != null && input.SkippedCheckItemList != null && !this.SkippedCheckItemList.SequenceEqual(input.SkippedCheckItemList))) return false;

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
                if (this.ClusterID != null) hashCode = hashCode * 59 + this.ClusterID.GetHashCode();
                if (this.ClusterVersion != null) hashCode = hashCode * 59 + this.ClusterVersion.GetHashCode();
                if (this.TargetVersion != null) hashCode = hashCode * 59 + this.TargetVersion.GetHashCode();
                if (this.SkippedCheckItemList != null) hashCode = hashCode * 59 + this.SkippedCheckItemList.GetHashCode();
                return hashCode;
            }
        }
    }
}
